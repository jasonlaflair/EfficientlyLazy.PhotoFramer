using System;
using System.Windows.Forms;

namespace EfficientlyLazy.PhotoFramer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //PhotoService.Cleanup();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDashboard());
        }
    }
}
