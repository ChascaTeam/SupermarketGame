using System.Collections.Generic;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.CustomerTypes
{
   public class AverageCustomer : Customer
    {
        
        public AverageCustomer(decimal money, List<Stock> wantedProducts, decimal priceTolerance)
            : base(money, wantedProducts, priceTolerance)
        {           
        }
    }
}
