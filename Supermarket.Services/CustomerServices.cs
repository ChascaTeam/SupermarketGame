namespace Supermarket.Services
{
    using System.Collections.Generic;
    using Supermarket.Data;
    using Supermarket.Models.Interfaces;

    public class CustomerServices : CustomerData
    {
        public void AddCustomer(ICustomer customer)
        {
            this.Customers.Add(customer);
        }

        public void RemoveCustomer(ICustomer customer)
        {
            this.Customers.Remove(customer);
        }

        public IList<ICustomer> GetAllCustomers()
        {
            return this.Customers;
        }
    }
}