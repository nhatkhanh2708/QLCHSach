using MVP.Views;
using System;
using System.Windows.Forms;

namespace Model.Entities
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Startup.ConfigureServices();
            //Application.Run(new Login());
            Application.Run(new Main());
        }
    }
}
