using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Supermarket.Models.Interfaces;
using Supermarket.Models.StockTypes;
using Supermarket.Models.WorkerTypes;

namespace Supermarket.Models.Management
{
    public class SupermarketManager
    {
        public SupermarketManager(Warehouse warehouse, decimal currentCapital)
        {
            this.Warehouse = warehouse;
            this.Workers = new List<IWorkForce>();
            this.CurrentCapital = currentCapital;
        }

        public Warehouse Warehouse { get; }

        public List<IWorkForce> Workers { get; }

        public decimal CurrentCapital { get; set; }

        public void IncreaseWarehouseVolume(int amount)
        {
            this.Warehouse.IncreaseVolume(amount);
        }
        
        public void RestockWarehouse(List<Stock> stocks)
        {
            int stocksVolume = 0;

            foreach (var stock in stocks)
            {
                stocksVolume += stock.Quantity;
            }

            if (this.Warehouse.WarehouseVolume - this.Warehouse.FilledVolume() - stocksVolume >= 0)
            {
                foreach (var stock in stocks)
                {
                    this.Warehouse.AddStock(stock);
                }
            }
            else
            {
                throw new ArgumentException("Warehouse doesn't have enough space!");
            }         
        }

        public string CheckCurrentStockInWarehouse()
        {
            var result = new StringBuilder();

            foreach (var product in this.Warehouse.StoredProducts)
            {
                result.AppendLine($"{product.ProductName} - {product.Quantity}");
            }

            return result.ToString();
        }

        public void ChangeProductPrice(Stock product, decimal newPrice)
        {
            product.ChangePrice(newPrice);
        }
    }
}
