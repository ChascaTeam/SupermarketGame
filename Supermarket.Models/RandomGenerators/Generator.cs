using System.Collections.Generic;
using Supermarket.Models.Factories;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.RandomGenerators
{
   public class Generator : RNDGenerator
    {
        private WorkerFactory workerFactory = new WorkerFactory();
        private CustomerFactory customerFactory = new CustomerFactory();
        private StockFactory stockFactory = new StockFactory();
        private DecimalGenerator generator = new DecimalGenerator();

        //Generates randomly stocks' prices and quantities
        public List<IStock> GenerateStock()
        {
            List<IStock> stock = new List<IStock>();

            return stock;
        }

        public List<IWorkForce> GenerateWorkersForHire()
        {           
            List<IWorkForce> workersForHire = new List<IWorkForce>();

            for (int i = 0; i < 5; i++)
            {
                workersForHire.Add(this.workerFactory.Get(base.rnd(0, 3)));
            }
            return workersForHire;
        }

        public List<ICustomer> GenerateCustomers()
        {
            List<ICustomer> customers = new List<ICustomer>();

            for (int i = 0; i < this.generator.rnd(5,50); i++)
            {
                customers.Add(this.customerFactory.Get(base.rnd(0, 4)));
            }

            return customers;
        }

    }
}
