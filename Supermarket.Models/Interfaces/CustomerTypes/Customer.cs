using System;
using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.CustomerTypes
{
   public abstract class Customer : ICustomer
    {
        public decimal MoneyInCash { get; }
        public decimal MoneyInCard { get; }

        //randomly generated list of products from the StockGenerator
        public List<IStock> WantedProducts { get; }
      
        public decimal BuyWantedProducts()
        {
            throw new NotImplementedException();
        }
      
        public void PriceTolerance()
        {
            throw new NotImplementedException();
        }
    }
}
