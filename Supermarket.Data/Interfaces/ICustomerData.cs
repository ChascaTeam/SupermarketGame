namespace Supermarket.Data.Interfaces
{
    using System.Collections.Generic;
    using Supermarket.Models.Interfaces;

    public interface ICustomerData
    {
        IList<ICustomer> Customers { get; }
    }
}