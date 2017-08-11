using System;
using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Management.Management
{
   public class Warehouse
    {
        public readonly List<IStock> StoredProducts;

        public Warehouse()
        {
            this.StoredProducts = new List<IStock>();
        }

        public int WarehouseVolume { get; private set; }
        public double WarehouseRent { get; }

        public void IncreaseVolume(int volume)
        {
            this.WarehouseVolume += volume;
        }

        public void AddStock(IStock stock)
        {
            //Add checks about volume
            this.StoredProducts.Add(stock);
        }
    }
}
