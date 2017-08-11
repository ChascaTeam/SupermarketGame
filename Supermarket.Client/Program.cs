using System;
using System.Windows.Forms;
using Supermarket.Client.Forms;
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
            Warehouse wh = new Warehouse();
            wh.AddStock(new Alcohol(){Quantity = 5});
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuStartForm());
        }
    }
}
