using System;
using System.Collections.Generic;


namespace Supermarket_Management.ClientTypes
{
   public abstract class Client : Generator, IClient
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
