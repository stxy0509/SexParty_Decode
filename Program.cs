using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JqpdDecode
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Decode_Form f = new Decode_Form();
            Application.Run(f);
        }
        public const string createTableCommand = "create table jqpd(time text,usage text,ln int,mn int,profit int,lockCount int);";
    }
}
