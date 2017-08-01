using System.Collections.Generic;

namespace Supermarket_Management
{
    public class Engine
    {
        private SupermarketManager manager;
        private List<ICustomer> customers;
        private StockExchange stockExchange;
        private LaborExchange laborExchange;

        public Engine()
        {
            this.manager = new SupermarketManager(new Warehouse(), 10000);
            this.customers = new List<ICustomer>();
            this.stockExchange = new StockExchange(new List<IStock>());
            this.laborExchange = new LaborExchange(new List<IWorkForce>());
        }

        public void Run()
        {
            //Mananger work. (buy stock, hire/fire workers)
            //Start of day. (calculate net income)
            //End of day (add net income to capital)
            //Check if goal is meet(enough capital or bankruptcy)
            //else Repeat
        }
    }
}
