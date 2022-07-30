using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 漏电检测系统
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
            LoginForm form = new LoginForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Application.Run(new FormMain());
            }
            else
            {
                return;
            }
            //Application.Run(new FormMain());
        }
    }
}
