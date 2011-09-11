using System;
using System.Windows.Forms;
using EfficientlyLazy.PhotoFramer.Services;

namespace EfficientlyLazy.PhotoFramer.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BootStrapper.Start();

            AppSettings.CameraRoot = @"C:\Users\Jason\Desktop\CameraPath";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
