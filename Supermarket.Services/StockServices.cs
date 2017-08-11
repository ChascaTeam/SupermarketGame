using System.Collections.Generic;
using System.Linq;
using Supermarket.Data;
using Supermarket.Models.Interfaces;
using Supermarket.Models.StockTypes;
using Supermarket.Management.Management;

namespace Supermarket.Services
{
    public class StockServices : StockData
    {
        public void AddStock(IStock stock)
        {                 
            Stock.Add(stock);
        }

        public void RemoveStock(IStock stock)
        {
            Stock.Remove(stock);
        }

        public IList<IStock> GetAllAlcohol()
        {
            return Stock.Where(x => x.GetType() == typeof(Alcohol)).ToList();
        }
    }
}