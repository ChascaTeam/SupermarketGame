namespace Supermarket.Models.Market
{
    using System.Collections.Generic;
    using Supermarket.Models.StockTypes;

    public class StockExchange
    {
        private List<Stock> availableStock;

        public StockExchange(List<Stock> availableProducts)
        {
            this.AvailableStock = availableProducts;
        }

        public List<Stock> AvailableStock
        {
            get { return this.availableStock; }
            protected set { this.availableStock = value; }
        }
    }
}
