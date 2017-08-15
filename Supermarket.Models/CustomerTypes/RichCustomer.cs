using System.Collections.Generic;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.CustomerTypes
{
    public class RichCustomer : Customer
    {
        public RichCustomer(decimal money, List<Stock> wantedProducts, decimal priceTolerance) 
            : base(money, wantedProducts, priceTolerance)
        {
        }
    }
}
