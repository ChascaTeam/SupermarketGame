using System.Collections.Generic;
using Supermarket.Models.Factories;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.RandomGenerators
{
   public class CustomerGenerator : RNDGenerator
    {
        private CustomerFactory customerFactory = new CustomerFactory();
        private DecimalGenerator generator = new DecimalGenerator();

        public List<ICustomer> GenerateCustomers()
        {
            List<ICustomer> customers = new List<ICustomer>();

            for (int i = 0; i < this.generator.Rnd(5,50); i++)
            {
                customers.Add(this.customerFactory.Get(base.Rnd(0, 4)));
            }

            return customers;
        }

    }
}
