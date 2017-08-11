using System.Collections.Generic;
using Supermarket.Models.StockTypes;

namespace Supermarket.Management.Management
{
    public class Warehouse
    {
        private decimal warehouseRent;

        private List<Stock> storedProducts;

        public Warehouse()
        {
            this.StoredProducts = new List<Stock> { new Alcohol(), new DairyProducts(), new Meat(), new Sweets(), new Vegetables() };
            this.WarehouseRent = 50m;
        }

        public List<Stock> StoredProducts { get; protected set; }

        public int WarehouseVolume { get; protected set; }

        public decimal WarehouseRent
        {
            get { return this.warehouseRent; }
           protected set { this.warehouseRent = value; }
        }

        public void IncreaseVolume(int volume)
        {
            this.WarehouseVolume += volume;
        }

        public int FilledVolume()
        {
            int stockInStore = 0;

            foreach (var product in this.StoredProducts)
            {
                stockInStore += product.Quantity;
            }

            return stockInStore;
        }

        public void AddStock(Stock stock)
        {
            switch (stock.ProductName)
            {
                case "Alcohol":
                    this.StoredProducts[0].Quantity += stock.Quantity;
                    break;
                case "DairyProducts":
                    this.StoredProducts[1].Quantity += stock.Quantity;
                    break;
                case "Meat":
                    this.StoredProducts[2].Quantity += stock.Quantity;
                    break;
                case "Sweets":
                    this.StoredProducts[3].Quantity += stock.Quantity;
                    break;
                case "Vegetables":
                    this.StoredProducts[4].Quantity += stock.Quantity;
                    break;
            }
        }
    }
}
