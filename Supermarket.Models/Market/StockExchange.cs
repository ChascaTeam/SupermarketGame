namespace Supermarket.Models.Market
{
    using System.Collections.Generic;
    using Supermarket.Models.StockTypes;

    public class StockExchange
    {
        public StockExchange(List<Stock> availableProducts)
        {
            this.AvailableStock = availableProducts;
        }

        public List<Stock> AvailableStock { get; protected set; }
    }
}
