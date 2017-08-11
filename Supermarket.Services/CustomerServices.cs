﻿using System.Collections.Generic;
using Supermarket.Data;
using Supermarket.Models.Interfaces;


namespace Supermarket.Services
{
    public class CustomerServices : CustomerData
    {
        

        public void AddCustomer(ICustomer customer)
        {
            Customers.Add(customer);
        }

        public void RemoveCustomer(ICustomer customer)
        {
            Customers.Remove(customer);
        }

        public IList<ICustomer> GetAllCustomers()
        {
            return Customers;
        }
    }
}