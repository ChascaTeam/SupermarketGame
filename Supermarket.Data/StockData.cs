using System.Collections.Generic;
using Supermarket.Data.Interfaces;
using Supermarket.Models.Interfaces;
using Supermarket.Models.StockTypes;

namespace Supermarket.Data
{
    public class StockData : IStockData
    {
        private IList<Stock> stock;

        public StockData()
        {
            this.Stock = new List<Stock>();
        }
        public IList<Stock> Stock
        {
            get { return stock; }
            set { stock = value; }
        }

    }
}