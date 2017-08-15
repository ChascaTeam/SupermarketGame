using System.Collections.Generic;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.CustomerTypes
{
    public class VeryPoorCustomer : Customer
    {
        public VeryPoorCustomer(decimal money, List<Stock> wantedProducts, decimal priceTolerance)
            : base(money, wantedProducts, priceTolerance)
        {
        }
    }
}
