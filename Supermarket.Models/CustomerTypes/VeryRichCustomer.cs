using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.CustomerTypes
{
   public class VeryRichCustomer : Customer
    {
        public VeryRichCustomer(decimal money, List<IStock> wantedProducts, decimal priceTolerance) : base(money, wantedProducts, priceTolerance)
        {
        }
    }
}
