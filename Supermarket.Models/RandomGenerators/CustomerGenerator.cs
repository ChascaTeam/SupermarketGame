using System.Collections.Generic;
using Supermarket.Models.Factories;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.RandomGenerators
{
   public class CustomerGenerator
    {
        private CustomerFactory customerFactory = new CustomerFactory();
        private IntGenerator generator = new IntGenerator();

        public List<ICustomer> GenerateCustomers()
        {
            List<ICustomer> customers = new List<ICustomer>();

            for (int i = 0; i < this.generator.Rnd(30,100); i++)
            {
                customers.Add(this.customerFactory.Get(this.generator.Rnd(0, 4)));
            }

            return customers;
        }

    }
}
