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
    }
}
