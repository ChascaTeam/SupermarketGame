using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Data
{
    public interface IStockData
    {
        IList<IStock> Stock { get; }
    }
}