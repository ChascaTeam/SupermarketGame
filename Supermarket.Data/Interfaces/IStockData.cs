using System.Collections.Generic;

using Supermarket.Models.StockTypes;

namespace Supermarket.Data.Interfaces
{
    public interface IStockData
    {
        IList<Stock> Stock { get; }
    }
}