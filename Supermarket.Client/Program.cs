using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Supermarket.Client.Forms;
using Supermarket.Management;
using Supermarket.Models.Management;
using Supermarket.Models.StockTypes;

namespace Supermarket.Client
{
    public static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}
