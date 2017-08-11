using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using Supermarket.Models.Interfaces;
using Supermarket.Models.StockTypes;
using Supermarket.Models.WorkerTypes;


namespace Supermarket.Management.Management
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
        public decimal CurrentCapital { get; }

        public void IncreaseWarehouseVolume(int amount)
        {
            this.Warehouse.IncreaseVolume(amount);
        }

        public void HireWorker(Worker worker)
        {
            this.Workers.Add(worker);
        }

        public void FireWorker(Worker worker)
        {
            this.Workers.Remove(worker);
        }

        //total workers salary + warehouse rent per day
        public decimal TotalFixedCostPerDay()
        {
            return this.Workers.Sum(w => w.SalaryPerDay) + (decimal)this.Warehouse.WarehouseRent;
        }

        public void RestockWarehouse(params IStock[] stocks)
        {
            foreach (var stock in stocks)
            {
                this.Warehouse.AddStock(stock);
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
