namespace Supermarket.Data.Interfaces
{
    using System.Collections.Generic;
    using Supermarket.Models.StockTypes;

    public interface IStockData
    {
        IList<Stock> Stock { get; }
    }
}