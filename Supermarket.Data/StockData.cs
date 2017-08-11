using System.Collections.Generic;
using Supermarket.Data.Interfaces;
using Supermarket.Models.Interfaces;

namespace Supermarket.Data
{
    public class StockData : IStockData
    {
        private IList<IStock> stock;

        public StockData()
        {
            this.Stock = new List<IStock>();
        }
        public IList<IStock> Stock
        {
            get { return stock; }
            set { stock = value; }
        }

    }
}