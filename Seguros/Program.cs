using Seguros.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Seguros
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzEwNDA0QDMxMzgyZTMyMmUzMGJhMGlFNzJ2cjB1SzdNNVZ2UDNZU1ZWTXBGWmJVdEN4eGp5TndiVUhRNDA9");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new calendar());
        }
    }
}
