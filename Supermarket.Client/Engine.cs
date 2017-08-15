using System.Collections.Generic;
using Supermarket.Data;
using Supermarket.Models.Client_Counter;
using Supermarket.Models.Interfaces;
using Supermarket.Models.Management;
using Supermarket.Models.Market;
using Supermarket.Models.RandomGenerators;


namespace Supermarket.Client
{
    public class Engine
    {
        internal static StockExchange stockExchange = new StockExchange(new StockGenerator().GenerateStockForShop());
        internal static IList<ICustomer> customers = new CustomerData().Customers;
        internal static IList<IWorkForce> workers = new WorkerData().Workers;
        internal static LaborExchange laborExchange = new LaborExchange(new List<IWorkForce>());
        internal static decimal income;
        internal static int daysPassed = 1;
        internal static IClientCounter counter = new ClientsMood();
        internal static SupermarketManager manager = new SupermarketManager(new Warehouse(), 1000);
    }
}
