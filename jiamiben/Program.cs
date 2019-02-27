using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Jiamiben
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 0)
            {
                Application.Run(new DesViewer());
            }
            else
            {
                Application.Run(new DesViewer(args[0]));
            }
        }
    }
}
