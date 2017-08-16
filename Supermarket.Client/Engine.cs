namespace Supermarket.Client
{
    using System.Collections.Generic;
    using Supermarket.Data;
    using Supermarket.Models.Client_Counter;
    using Supermarket.Models.Interfaces;
    using Supermarket.Models.Management;
    using Supermarket.Models.Market;
    using Supermarket.Models.RandomGenerators;

    public class Engine
    {
        internal static StockExchange stockExchange;
        internal static IList<ICustomer> customers;
        internal static IList<IWorkForce> workers;
        internal static LaborExchange laborExchange;
        internal static decimal income;
        internal static decimal PreviousDayIncome;
        internal static int daysPassed;
        internal static IClientCounter counter;
        internal static SupermarketManager manager;

        public void Run()
        {
            stockExchange = new StockExchange(new StockGenerator().GenerateStockForShop());
            customers = new CustomerData().Customers;
            workers = new WorkerData().Workers;
            laborExchange = new LaborExchange(new List<IWorkForce>());
            income = 0;
            PreviousDayIncome = 0;
            daysPassed = 1;
            counter = new ClientsMood();
            manager = new SupermarketManager(new Warehouse(), 1000);
        }
    }
}
