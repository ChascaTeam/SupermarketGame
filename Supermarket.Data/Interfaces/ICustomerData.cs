using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Data.Interfaces
{
    public interface ICustomerData
    {
        IList<ICustomer> Customers { get; }
    }
}