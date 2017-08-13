using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.CustomerTypes
{
    public class VeryPoorCustomer : Customer
    {
        public VeryPoorCustomer(decimal money, List<IStock> wantedProducts, decimal priceTolerance) : base(money, wantedProducts, priceTolerance)
        {
        }
    }
}
