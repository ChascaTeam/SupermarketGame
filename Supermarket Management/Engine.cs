using System.Collections.Generic;
using Supermarket.Data;
using Supermarket.Data.Interfaces;
using Supermarket.Management.Market;
using Supermarket.Models.Interfaces;
using Supermarket.Models.Management;
using Supermarket.Models.RandomGenerators;
using System;
using Supermarket.Models.StockTypes;
namespace Supermarket.Management
{
    public class Engine
    {
        private SupermarketManager manager;
        private IList<ICustomer> customers;
        private StockExchange stockExchange;
        private LaborExchange laborExchange;
        private IList<IWorkForce> workers;
        private int daysPassed;

        public Engine()
        {
            ICustomerData cd = new CustomerData();
            IStockData sd = new StockData();
            IWorkerData wd = new WorkerData();

            this.manager = new SupermarketManager(new Warehouse(), 10000);
            this.customers = cd.Customers;
            this.stockExchange = new StockExchange(new List<IStock>());
            this.laborExchange = new LaborExchange(new List<IWorkForce>());
            this.workers = wd.Workers;
        }

        public void Run()
        {
            this.CreateLaborMarketData();
                  this.CreateCustomersList();
                  
                  
            //Manager work. (buy stock, hire/fire workers)
            //Start of day. (calculate net income)
            //End of day (add net income to capital)
            //Check if goal is meet(enough capital or bankruptcy)
            //else Repeat
        }

        private void CreateLaborMarketData()
        {
            this.workers = new WorkForceGenerator().GenerateWorkersForHire();
        }

        private void CreateCustomersList()
        {
            this.customers = new CustomerGenerator().GenerateCustomers();
        }
    }
}
