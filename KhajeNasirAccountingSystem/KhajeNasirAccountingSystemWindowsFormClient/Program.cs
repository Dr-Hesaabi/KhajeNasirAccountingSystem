using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhajeNasirAccountingSystemWindowsFormClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += (sender, args) => WholeApplicatiomError(args.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => WholeApplicatiomError(args.ExceptionObject as Exception);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void WholeApplicatiomError(Exception e)
        {
            MessageBox.Show("خطای سیستم"+"\r\n"+e.Message);

        }
    }
}
