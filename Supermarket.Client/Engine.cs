using System.Collections.Generic;
using System.Linq;
using Supermarket.Client.Forms;
using Supermarket.Data;
using Supermarket.Data.Interfaces;
using Supermarket.Management.Market;
using Supermarket.Models;
using Supermarket.Models.Client_Counter;
using Supermarket.Models.Interfaces;
using Supermarket.Models.Management;
using Supermarket.Models.RandomGenerators;
using Supermarket.Models.StockTypes;
using Supermarket.Models.WorkerTypes;

namespace Supermarket.Client
{
    public class Engine
    {
        
        private IList<ICustomer> customers;
        private StockExchange stockExchange;
        private LaborExchange laborExchange;
        private IList<IWorkForce> workers;
        private IClientCounter counter = new ClientsMood();

        internal static decimal income;
        internal static int daysPassed = 1;
        internal static SupermarketManager manager = new SupermarketManager(new Warehouse(), 1000);

        public Engine()
        {
            ICustomerData cd = new CustomerData();
            IStockData sd = new StockData();
            IWorkerData wd = new WorkerData();

            this.customers = cd.Customers;
            this.stockExchange = new StockExchange(new List<IStock>());
            this.laborExchange = new LaborExchange(new List<IWorkForce>());
            this.workers = wd.Workers;
        }

        public void Run()
        {
             
                //Creates a list of workers
                this.CreateLaborMarketData();

                //Creates a list of customers
                this.CreateCustomersData();

                //Checks how many clients the workers can take
                this.CalculateWorkersPower();

                //Simulates buying from the shop
                foreach (var customer in this.customers)
                {
                    this.CustomersShopping(manager.Warehouse.StoredProducts, customer);
                }

            //calculates total cost (not needed just for test)
            var weges = manager.SalaryCostsPerDay();
            var rent = manager.Warehouse.WarehouseRent;

            
        

        //Manager work. (buy stock, hire/fire workers)
        //Start of day. (calculate net income)
        //End of day (add net income to capital)
        //Check if goal is meet(enough capital or bankruptcy)
        //else Repeat
    }

        private void IncreaseWarehouseVolume()
        {
            decimal volumeCost = 100m + daysPassed;
            decimal rentIncrease = 10m + daysPassed;
            int volumeIncrease = 15 + daysPassed;

            income -= volumeCost;
            manager.Warehouse.WarehouseRent += rentIncrease;
            manager.Warehouse.IncreaseVolume(volumeIncrease);
        }

        private void CalculateWorkersPower()
        {
            int numOfClients = 0;

            foreach (var worker in this.workers)
            {
                numOfClients += worker.CustomersPerDay;
            }

            if (numOfClients < this.customers.Count)
            {
                this.counter.UnsatisfiedNumber += this.customers.Count - numOfClients;
                if (numOfClients == 0)
                {
                    this.customers.Clear();
                }
                else
                {
                    this.customers = this.customers.Take(numOfClients).ToList();
                }
                
            }          
           
        }

        private void CustomersShopping(List<Stock> productsInStore, ICustomer customer)
        {
            decimal quantity;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (productsInStore[i].ProductName.Equals(customer.WantedProducts[j].ProductName))
                    {
                        if (productsInStore[i].Quantity >= customer.WantedProducts[j].Quantity)
                        {
                            quantity = customer.WantedProducts[j].Quantity;
                            income += this.SpentMoney(quantity, productsInStore[i], customer, i);

                        }
                        else
                        {
                            quantity = productsInStore[i].Quantity;
                            income += this.SpentMoney(quantity, productsInStore[i], customer, i);
                        }
                        break;
                    }
                }

                if (customer.HasShoped)
                {
                    this.counter.AddSatisfied();
                }
                else
                {
                    this.counter.AddUnsatisfied();
                }
            }
        }

        private decimal SpentMoney(decimal quantity, Stock product, ICustomer customer, int i)
        {
            decimal spentMoney = 0m;

            if (product.Price <= customer.PriceTolerance)
            {
                for (int k = 0; k < quantity; k++)
                {
                    if (customer.Money > product.Price)
                    {
                        spentMoney += product.Price;
                        customer.Money -= product.Price;
                        manager.Warehouse.StoredProducts[i].Quantity--;

                    }
                    else
                    {
                        break;
                    }
                }
            }

            return spentMoney;
        }

        private void CreateLaborMarketData()
        {
            this.laborExchange = new LaborExchange(new WorkForceGenerator().GenerateWorkersForHire());
        }

        private void CreateCustomersData()
        {
            this.customers = new CustomerGenerator().GenerateCustomers();
        }
    }
}
