using System;
using System.Collections.Generic;
using Supermarket.Models.Interfaces;
using Supermarket.Models.RandomGenerators;
using Supermarket.Models.StockTypes;

namespace Supermarket.Management.Market
{
    public class StockExchange : RNDGenerator
    {
        public StockExchange(List<Stock> availableProducts)
        {
            this.AvailableStock = availableProducts;
        }

        public List<Stock> AvailableStock { get; protected set; }
    }
}
