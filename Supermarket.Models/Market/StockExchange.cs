using System.Collections.Generic;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.Market
{
    public class StockExchange
    {
        public StockExchange(List<Stock> availableProducts)
        {
            this.AvailableStock = availableProducts;
        }

        public List<Stock> AvailableStock { get; protected set; }
    }
}
