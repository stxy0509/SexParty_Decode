using System;
using System.Windows.Forms;
using System.Data.SQLite;
namespace JqpdDecode
{
    public partial class Decode_Form : Form
    {
        private Timer passwordTimer;
        private const int MaxFigure3 = 999;
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
        private uint passwordBase = 0;
        private const int CodeFlag = 20131202;
        private SQLiteCommand command;
        public static SQLiteConnection dataBase;
        private void AddNewRecord()
        {
            try
            {
                InsertRecord();
            }
            catch(SQLiteException sqlex)
            {
                command.CommandText = "create table jqpd(time text,ln int,mn int,profit int,lockCount int);";
                command.ExecuteNonQuery();
                InsertRecord();
            }
        }

        bool RecordExist(int ln,int mn,int profit,int count)
        {        
            SQLiteDataReader reader;
            command.CommandText = "select count(*) from jqpd where ";
            command.CommandText += "ln = " + ln + " AND ";
            command.CommandText += "mn = " + mn + " AND ";
            command.CommandText += "profit = " + profit + " AND ";
            command.CommandText += "lockCount = " + count + ";";
            try
            {
                reader = command.ExecuteReader();
                if(reader.Read())
                {
                    return reader.GetInt32(0) > 0;
                }
            }
            catch(SQLiteException sqlex)
            {
                command.CommandText = "create table jqpd(time text,ln int,mn int,profit int,lockCount int);";
                command.ExecuteNonQuery();
            }
            return false;
        }

        private void InsertRecord()
        {
            string tempString = "insert into jqpd values(datetime('now','localtime'),";
            command.CommandText = tempString + reportLineNumber + "," +
                reportMachineNumber + "," +
                reportProfit + "," +
                reportLockCount + ");";
            command.ExecuteNonQuery();
        }

        public Decode_Form()
        {
            InitializeComponent();
            passwordTimer = new Timer();
            passwordTimer.Interval = 6000;
            passwordTimer.Tick += new EventHandler(PasswordTimeOver);
        }
    
        private void PasswordTimeOver(object sender, EventArgs e)
        {
            passwordTimer.Stop();
            labelPassword.Text = "";
        }

        private void DecodeForm_Load(object sender, EventArgs e)
        {
            optionString.Text = options[optionIndex];
            newLnMnTB.Text = "";
            dataBase = new SQLiteConnection("Data Source = decode.db");
            dataBase.Open();
            command = dataBase.CreateCommand();
        }

        private void DoDecode_Click(object sender, EventArgs e)
        {
            if(lineNumberTB.Text == "" || profitTB.Text == "" || machineNumTB.Text == "" ||
                lockCountTB.Text == "" || chkCodeTB.Text == "")
            {
                MessageBox.Show("部分数据空白，请输入!");
                return;
            }
            if(reportLineNumber < 0 || reportLineNumber > MaxFigure3)
            {
                MessageBox.Show("输入的线号无效，请检查数据!");
                return;
            }
            if(reportMachineNumber < 0 || reportMachineNumber > 99999999)
            {
                MessageBox.Show("机台号码无效，请检查数据!");
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
                newPassword = (passwordBase + optionIndex * computedCode).ToString("d8");
            }
            else if(optionIndex == 13)
            {
                try
                {
                    newLineNumber = int.Parse(newLnMnTB.Text);
                }
                catch(System.Exception exce)
                {
                    MessageBox.Show("新线号无效!");
                    return;
                }
                if(newLineNumber < 0 || newLineNumber > MaxFigure3)
                {
                    MessageBox.Show("新线号无效!");
                    return;
                }
                newPassword = (passwordBase - computedCode - newLineNumber).ToString("d8");
            }
            else
            {
                try
                {
                    newMachineNumber = int.Parse(newLnMnTB.Text);
                }
                catch(System.Exception exce)
                {
                    MessageBox.Show("新机台号码无效!");
                    return;
                }
                if(newMachineNumber < 0 || newMachineNumber > MaxFigure3)
                {
                    MessageBox.Show("新机台号码无效!");
                    return;
                }
                newPassword = (passwordBase - computedCode - 1000 - newMachineNumber).ToString("d8");
            }
            if(reportProfit > 0 && !RecordExist(reportLineNumber,reportMachineNumber,reportProfit,reportLockCount))
            {
                AddNewRecord();
            }
            passwordTimer.Stop();
            passwordTimer.Start();
            labelPassword.Text = newPassword.Substring(0, 4) + " " + newPassword.Substring(4);           
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
            passwordBase = TempCheck[5] % 99000000;
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
                newLnMnTB.Visible = true;
                newLnMnTB.Enabled = true;
            }
            else
            {
                newLnMnTB.Visible = false;
                newLnMnTB.Enabled = false;
            }
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

        private void DecodeForm_Closed(object sender, FormClosedEventArgs e)
        {
            dataBase.Close();
            dataBase.Dispose();
            passwordTimer.Stop();
            passwordTimer.Dispose();
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
            labelLength.Text = tb.Text.Length.ToString();
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
