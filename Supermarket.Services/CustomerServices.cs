using System.Collections.Generic;
using Supermarket.Data;
using Supermarket_Management;

namespace Supermarket.Services
{
    public class CustomerServices
    {
        public void AddCustomer(ICustomer customer)
        {
            CustomerData.Customers.Add(customer);
        }

        public void RemoveCustomer(ICustomer customer)
        {
            CustomerData.Customers.Remove(customer);
        }

        public IList<ICustomer> GetAllCustomers()
        {
            return CustomerData.Customers;
        }
    }
}