using System.Collections.Generic;
using System.Linq;
using Supermarket.Data;
using Supermarket.Models.StockTypes;

namespace Supermarket.Services
{
    public class StockServices : StockData
    {
        public void AddStock(Stock stock)
        {                 
            this.Stock.Add(stock);
        }

        public void RemoveStock(Stock stock)
        {
            this.Stock.Remove(stock);
        }

        public IList<Stock> GetAllAlcohol()
        {
            return this.Stock.Where(x => x.GetType() == typeof(Alcohol)).ToList();
        }
    }
}