using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text;
namespace JqpdDecode
{
    public partial class DbViewForm : Form
    {
        private int startPos = 0;
        private int totalSize = 0;
        private const int itemsPerPage = 20;
        public DbViewForm()
        {
            InitializeComponent();
            dataTable.GridLines = true;     //表格是否显示网格线
            dataTable.FullRowSelect = true; //是否选中整行

            dataTable.View = View.Details;  //设置显示方式
            dataTable.Scrollable = true;    //是否自动显示滚动条
            dataTable.MultiSelect = false;  //是否可以选择多行

            //添加表头（列）
            dataTable.Columns.Add("序号",  60, HorizontalAlignment.Center);
            dataTable.Columns.Add("时间", 180, HorizontalAlignment.Center);
            dataTable.Columns.Add("用途",  80, HorizontalAlignment.Center);
            dataTable.Columns.Add("线号",  60, HorizontalAlignment.Center);
            dataTable.Columns.Add("机台号码", 100, HorizontalAlignment.Center);
            dataTable.Columns.Add("游戏时间", 100, HorizontalAlignment.Center);
            dataTable.Columns.Add("打码次数",  80, HorizontalAlignment.Center);

            totalSize = GetRecordSize();
            if (totalSize > 0)
            {
                DisplayItems();
            }
            else
            {
                pageTimeLabel.Text = "0分钟";
            }
        }

        private void DisplayItems()
        {
            int i = startPos, profit = 0;
            SQLiteDataReader reader;

            dataTable.Items.Clear();
            SQLiteCommand command = Decode_Form.dataBase.CreateCommand();
            command.CommandText = "select * from jqpd limit " + startPos + "," + itemsPerPage + ";";
            try
            {
                reader = command.ExecuteReader();
            }
            catch (SQLiteException sqlex)
            {
                return;
            }
            int pageTime = 0;
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();
                item.SubItems[0].Text = (i + 1).ToString();
                item.SubItems.Add(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetInt32(2).ToString("d3"));
                item.SubItems.Add(reader.GetInt32(3).ToString("d8"));
                profit = reader.GetInt32(4);
                item.SubItems.Add(profit.ToString());
                item.SubItems.Add(reader.GetInt32(5).ToString());
                dataTable.Items.Add(item);
                ++i;
                pageTime += profit;
            }
            reader.Close();
            pageTimeLabel.Text = (pageTime).ToString() + "分钟";
        }

        private int GetRecordSize()
        {
            int size = 0;
            int totalTime = 0;
            SQLiteDataReader reader;
            SQLiteCommand command = Decode_Form.dataBase.CreateCommand();
            command.CommandText = "select count(*),sum(profit) from jqpd;";
            try
            {
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    size = reader.GetInt32(0);
                    if (size > 0)
                    {
                        totalTime = reader.GetInt32(1);
                    }
                    reader.Close();
                }
            }
            catch (SQLiteException sqlex)
            {
                command.CommandText = Program.createTableCommand;
                command.ExecuteNonQuery();
            }
            totalTimeLabel.Text = totalTime.ToString() + "分钟";
            return size;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if(totalSize == 0)
            {
                return;
            }
            DialogResult res = MessageBox.Show("确定要清除打码记录吗?", "确认删除", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                SQLiteCommand command = Decode_Form.dataBase.CreateCommand();
                command.CommandText = "delete from jqpd where 1;";
                try
                {
                    command.ExecuteNonQuery();
                    dataTable.Items.Clear();
                    totalTimeLabel.Text = "0分钟";
                    pageTimeLabel.Text = "0分钟";
                }
                catch (SQLiteException sqlex)
                {
                }
            }
            else if (res == DialogResult.No)
            {
                return;
            }
        }

        private void prevPage_Click(object sender, EventArgs e)
        {
            if (startPos < itemsPerPage)
            {
                return;
            }
            startPos -= itemsPerPage;
            DisplayItems();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            if (totalSize <= startPos + itemsPerPage)
            {
                return;
            }
            startPos += itemsPerPage;
            DisplayItems();
        }

        private void firstPage_Click(object sender, EventArgs e)
        {
            if (totalSize > 0)
            {
                startPos = 0;
                DisplayItems();
            }
        }

        private void lastPage_Click(object sender, EventArgs e)
        {
            if (totalSize > 0)
            {
                int r = totalSize % itemsPerPage;
                startPos = (r == 0 ? totalSize - itemsPerPage : totalSize / itemsPerPage * itemsPerPage);
                DisplayItems();
            }
        }
    }
}
