using System.Collections.Generic;
using System.Linq;
using Supermarket.Models.Interfaces;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.Management
{
    public class Warehouse
    {
        private decimal warehouseRent;

        public Warehouse()
        {
            this.StoredProducts = new List<Stock> { new Alcohol(), new DairyProducts(), new Meat(), new Sweets(), new Vegetables() };
            this.WarehouseRent = 50m;
            this.WarehouseVolume = 50;
        }

        public List<Stock> StoredProducts { get; protected set; }

        public int WarehouseVolume { get; protected set; }

        public decimal WarehouseRent
        {
            get { return this.warehouseRent; }
            set { this.warehouseRent = value; }
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

        public void AddStock(IStock stock)
        {
            this.StoredProducts.First(x => x.GetType() == stock.GetType()).Quantity += stock.Quantity;
        }
    }
}
