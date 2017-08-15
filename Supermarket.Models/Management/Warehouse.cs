using System.Collections.Generic;
using Supermarket.Models.Interfaces;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.Management
{
    public class Warehouse : IWarehouse
    {
        private decimal warehouseRent;
        private int warehouseVolume;

        public Warehouse()
        {
            this.StoredProducts = new List<Stock> { new Alcohol(), new DairyProducts(), new Meat(), new Sweets(), new Vegetables() };
            this.WarehouseRent = 25m;
            this.WarehouseVolume = 100;
        }

        public List<Stock> StoredProducts { get; protected set; }

        public int WarehouseVolume
        {
            get => this.warehouseVolume;
            protected set => this.warehouseVolume = value;
        }

        public decimal WarehouseRent
        {
            get => this.warehouseRent;
            set => this.warehouseRent = value;
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
    }
}
