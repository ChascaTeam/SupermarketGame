using System.Collections.Generic;
using Supermarket.Models.Factories;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.RandomGenerators
{
   public class StockGenerator : RNDGenerator
    {
        private StockFactory stockFactory = new StockFactory();
        private DecimalGenerator generator = new DecimalGenerator();

        //Generates randomly stocks' prices and quantities
        public List<IStock> GenerateStock()
        {
            List<IStock> stock = new List<IStock>();

            return stock;
        }

    }
}
