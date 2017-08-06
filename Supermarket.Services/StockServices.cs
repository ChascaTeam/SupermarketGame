using System.Collections.Generic;
using System.Linq;
using Supermarket.Data;
using Supermarket_Management;
using Supermarket_Management.StockTypes;

namespace Supermarket.Services
{
    public class StockServices
    {
        public void AddStock(IStock stock)
        {
            StockData.Stock.Add(stock);
        }

        public void RemoveStock(IStock stock)
        {
            StockData.Stock.Remove(stock);
        }

        public IList<IStock> GetAllAlcohol()
        {
            return StockData.Stock.Where(x => x.GetType() == typeof(Alcohol)).ToList();
        }
    }
}