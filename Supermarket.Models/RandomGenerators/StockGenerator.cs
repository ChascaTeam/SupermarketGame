using System.Collections.Generic;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.RandomGenerators
{
    public class StockGenerator : RNDGenerator
    {
        private IntGenerator generator = new IntGenerator();

        //Generates randomly stocks' quantities for customers' wanted list
        public List<Stock> GenerateStock(int start, int end)
        {
            List<Stock> stock = new List<Stock> { new Alcohol(), new DairyProducts(), new Meat(), new Sweets(), new Vegetables() };
          
            foreach (var product in stock)
            {
                product.Quantity += this.generator.Rnd(start,end);
            }

            return stock;
        }

    }
}
