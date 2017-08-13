using System;
using System.Collections.Generic;
using Supermarket.Models.Interfaces;
using Supermarket.Models.RandomGenerators;

namespace Supermarket.Management.Market
{
    public class StockExchange : RNDGenerator
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
