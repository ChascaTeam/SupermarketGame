using System.Collections.Generic;
using System.Linq;
using Supermarket.Data;
using Supermarket.Data.Interfaces;
using Supermarket.Management.Market;
using Supermarket.Models;
using Supermarket.Models.Client_Counter;
using Supermarket.Models.Interfaces;
using Supermarket.Models.Management;


namespace Supermarket.Client
{
    public class Engine
    {
        private StockExchange stockExchange;

        internal static IList<ICustomer> customers = new CustomerData().Customers;
        internal static IList<IWorkForce> workers = new WorkerData().Workers;
        internal static LaborExchange laborExchange = new LaborExchange(new List<IWorkForce>());
        internal static decimal income;
        internal static int daysPassed = 1;
        internal static IClientCounter counter = new ClientsMood();
        internal static SupermarketManager manager = new SupermarketManager(new Warehouse(), 1000);

        public Engine()
        {
            IStockData sd = new StockData();
            this.stockExchange = new StockExchange(new List<IStock>());
        }

        public void Run()
        {
        }
    }
}
