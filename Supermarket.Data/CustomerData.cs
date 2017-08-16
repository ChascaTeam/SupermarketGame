namespace Supermarket.Data
{
    using System.Collections.Generic;
    using Supermarket.Data.Interfaces;
    using Supermarket.Models.Interfaces;

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