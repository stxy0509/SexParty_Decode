using System;
using System.Windows.Forms;
using System.Data.SQLite;
namespace JqpdDecode
{
    public partial class Decode_Form : Form
    {
        private static int lineNumber = 100;
        private int[] ln = new int[3] { lineNumber / 100, lineNumber / 10 % 10, lineNumber % 10 };
        private static int machineNumber = 123;
        private int[] mn = new int[3] { machineNumber / 100, machineNumber / 10 % 10, machineNumber % 10 };
        private string[] options = new string[]
        {
            "保持现状",
            "20小时","30小时", "40小时", "50小时", "60小时",
            "80小时","100小时","120小时","150小时","180小时",
            "公司台", "买卖台",
            "线号","机号\n高3位"
        };
        private int reportLineNumber = 0;
        private int reportProfit = 0;
        private int reportMachineNumber = 0;
        private int reportLockCount = 0;
        private int reportChkCode = 0;

        private int newLineNumber = 0;
        private int newMachineNumber = 0;
        private int optionIndex = 0;
        private uint passwordV = 0;
        private const int CodeFlag = 20131202;
        private SQLiteCommand command;
        public static SQLiteConnection dataBase;
        private void AddNewRecord()
        {
            try
            {
                string tempString = "insert into jqpd values(datetime('now','localtime'),";
                command.CommandText = tempString + reportLineNumber + "," +
                    reportMachineNumber + "," +
                    reportProfit + "," +
                    reportLockCount + ");";
                command.ExecuteNonQuery();
            }
            catch(SQLiteException sqlex)
            {
                command.CommandText = "create table jqpd(time text,ln int,mn int,profit int,lockCount int);";
                command.ExecuteNonQuery();

                string tempString = "insert into jqpd values(datetime('now','localtime'),";
                command.CommandText = tempString + lineNumber + "," +
                    reportMachineNumber + "," +
                    reportProfit + "," +
                    reportLockCount + ");";
                command.ExecuteNonQuery();
            }
        }

        public Decode_Form()
        {
            InitializeComponent();          
        }

        private void TxForm_Load(object sender, EventArgs e)
        {
            optionString.Text = options[0];
            optionLnMn.Text = "";
            dataBase = new SQLiteConnection("Data Source = decode.db");
            dataBase.Open();
            command = dataBase.CreateCommand();
        }

        private void AllLabels_Click(object sender, EventArgs e)
        {

        }

        private void DoDecode_Click(object sender, EventArgs e)
        {
            if(reportLineNumber != lineNumber)
            {
                MessageBox.Show("线号不一致，请检查数据!");
                return;
            }
            int mnHigh = reportMachineNumber / 100000;
            if(mnHigh != machineNumber)
            {
                MessageBox.Show("机台号码高3位不一致，请检查数据!");
                return;
            }
            if(reportProfit < 0)
            {
                MessageBox.Show("总游戏时间不能小于0，请检查数据!");
                return;
            }
            if(reportLockCount < 0)
            {
                MessageBox.Show("打码次数不能小于0，请检查数据!");
                return;
            }
            if(reportChkCode < 0)
            {
                MessageBox.Show("校验码不能小于0，请检查数据!");
                return;
            }
            uint computedCode = ComputeCheckCode();
            if(computedCode != reportChkCode)
            {
                MessageBox.Show("非法数据，校验错误，请检查数据!");
                return;
            }
            string newPassword;
            if(optionIndex < 13)
            {
                newPassword = (passwordV + optionIndex * computedCode).ToString("d8");
            }
            else if(optionIndex == 13)
            {
                try
                {
                    newLineNumber = int.Parse(optionLnMn.Text);
                }
                catch(System.Exception exce)
                {
                    MessageBox.Show("新线号无效!");
                    return;
                }
                if(newLineNumber < 0 || newLineNumber > 999)
                {
                    MessageBox.Show("新线号无效!");
                    return;
                }
                newPassword = (passwordV - computedCode - newLineNumber).ToString("d8");
            }
            else
            {
                try
                {
                    newMachineNumber = int.Parse(optionLnMn.Text);
                }
                catch(System.Exception exce)
                {
                    MessageBox.Show("新机台号码无效!");
                    return;
                }
                if(newMachineNumber < 0 || newMachineNumber > 999)
                {
                    MessageBox.Show("新机台号码无效!");
                    return;
                }
                newPassword = (passwordV - computedCode - 1000 - newMachineNumber).ToString("d8");
            }
            if(reportProfit > 0)
            {
                AddNewRecord();
            }
            MessageBox.Show("密码是: " + newPassword.Substring(0, 4) + " " + newPassword.Substring(4), "打码成功!");
        }

        int GetNumberOfOneBit(uint v)
        {
            int n = 0;
            for(int i = 0; i < 32; i++)
            {
                if((v & (1 << i)) > 0)
                {
                    ++n;
                }
            }
            return n;
        }

        uint ComputeCheckCode()
        {
            uint temp,code = 0;
            uint[] TempCheck = new uint[6];

            temp = (uint)(reportProfit);
            TempCheck[0] = temp << 5;

            temp = (uint)(reportProfit);
            TempCheck[1] = temp << (GetNumberOfOneBit(temp) % 5);

            temp = (uint)reportMachineNumber;
            TempCheck[2] = temp << (GetNumberOfOneBit(temp) % 5);

            temp = (uint)reportLineNumber;
            TempCheck[3] = temp << (GetNumberOfOneBit(temp) % 5);

            temp = (uint)reportLockCount;
            TempCheck[4] = (temp + CodeFlag) << (GetNumberOfOneBit(temp) % 5);

            TempCheck[5] = TempCheck[4] ^ TempCheck[0];
            TempCheck[5] ^= TempCheck[1];
            TempCheck[5] ^= TempCheck[2];
            TempCheck[5] ^= TempCheck[3];

            code = ((TempCheck[5] >> 16) ^ (TempCheck[5] & 0xffff)) % 10000;
            passwordV = TempCheck[5] % 99000000;
            return code;
        }

        private void DecodeOptionButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ++optionIndex;
            if(optionIndex >= options.Length)
            {
                optionIndex = 0;
            }
            b.Text = options[optionIndex];
            if(b.Text == "线号" || b.Text.StartsWith("机号"))
            {
                optionLnMn.Visible = true;
                optionLnMn.Enabled = true;
            }
            else
            {
                optionLnMn.Visible = false;
                optionLnMn.Enabled = false;
            }
        }

        private void LineNumButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int s = int.Parse(b.Text);
            s = (s + 1) % 10;
            for(int i = 1; i <= 3; i++)
            {
                if(b.Name.EndsWith(i.ToString()))
                {
                    ln[i - 1] = s;
                    break;
                }
            }
            lineNumber = ln[0] * 100 + ln[1] * 10 + ln[2];
            b.Text = s.ToString();
        }

        private void MachineNumButton_Click(object sender, EventArgs e)
        {
            int i;
            Button b = (Button)sender;
            int s = int.Parse(b.Text);
            s = (s + 1) % 10;
            for(i = 0; i < mn.Length; i++)
            {
                if(b.Name.EndsWith((i + 1).ToString()))
                {
                    mn[i] = s;
                    break;
                }
            }
            b.Text = s.ToString();
            int sum = 0;
            for(i = 0; i < mn.Length; i++)
            {
                sum = 10 * sum + mn[i];
            }
            machineNumber = sum;
        }

        private void DbViewButton_Click(object sender, EventArgs e)
        {
            DbViewForm f = new DbViewForm();
            f.ShowDialog();
        }

        private void lockCount_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                reportLockCount = int.Parse(tb.Text);
            }
            catch(System.Exception ex)
            {
                reportLockCount = 0;
                tb.Text = "";
            }
        }

        private void TxForm_Closed(object sender, FormClosedEventArgs e)
        {
            dataBase.Close();
            dataBase.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lineNum_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                reportLineNumber = int.Parse(tb.Text);               
            }
            catch(System.Exception ex)
            {
                reportLineNumber = 0;
                tb.Text = "";
            }
        }

        private void profit_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                reportProfit = int.Parse(tb.Text);
            }
            catch(System.Exception ex)
            {
                reportProfit = 0;
                tb.Text = "";
            }
        }

        private void machineNum_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                reportMachineNumber = int.Parse(tb.Text);
            }
            catch(System.Exception ex)
            {
                reportMachineNumber = 0;
                tb.Text = "";
            }
        }

        private void chkCode_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                reportChkCode = int.Parse(tb.Text);
            }
            catch(System.Exception ex)
            {
                reportChkCode = 0;
                tb.Text = "";
            }
        }
    }
}
