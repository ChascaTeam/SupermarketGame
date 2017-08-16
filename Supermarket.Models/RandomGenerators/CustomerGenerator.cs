namespace Supermarket.Models.RandomGenerators
{
    using System.Collections.Generic;
    using Supermarket.Models.Factories;
    using Supermarket.Models.Interfaces;

    public class CustomerGenerator
    {
        private CustomerFactory customerFactory;
        private IntGenerator generator;

        public CustomerGenerator()
        {
            this.customerFactory = new CustomerFactory();
            this.generator = new IntGenerator();
        }

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
