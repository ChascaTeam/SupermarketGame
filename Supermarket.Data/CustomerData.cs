using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Data
{
    public class CustomerData : ICustomerData
    {
        private IList<ICustomer> customers;

        public CustomerData()
        {
            this.Customers = new List<ICustomer>();
        }
        public IList<ICustomer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }

    }
}