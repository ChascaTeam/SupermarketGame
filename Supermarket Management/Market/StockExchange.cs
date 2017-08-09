using System;
using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket_Management
{
    public class StockExchange : Generator
    {
        public StockExchange(List<IStock> availableProducts)
        {
            this.AvailableStock = availableProducts;
        }

        public List<IStock> AvailableStock { get; protected set; }

        public void ShowAvailableStock()
        {
            throw new NotImplementedException();
        }
    }
}
