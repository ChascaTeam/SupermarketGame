using System.Linq;

namespace Supermarket.Models.Management
{
    using System.Collections.Generic;
    using Supermarket.Models.Interfaces;
    using Supermarket.Models.StockTypes;

    public class Warehouse : IWarehouse
    {
        private decimal warehouseRent;
        private int warehouseVolume;

        public Warehouse()
        {
            this.StoredProducts = new List<Stock>
            { new Alcohol(), new DairyProducts(), new Meat(), new Sweets(), new Vegetables() };
            this.WarehouseRent = 25m;
            this.WarehouseVolume = 100;
        }

        public List<Stock> StoredProducts { get; protected set; }

        public int WarehouseVolume
        {
            get { return this.warehouseVolume; }
            protected set { this.warehouseVolume = value; }
        }

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
            return this.StoredProducts.Sum(product => product.Quantity);
        }
    }
}
