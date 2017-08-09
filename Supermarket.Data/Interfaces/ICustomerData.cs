using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Data
{
    public interface ICustomerData
    {
        IList<ICustomer> Customers { get; }
    }
}