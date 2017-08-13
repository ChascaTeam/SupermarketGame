using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.CustomerTypes
{
    public class PoorCustomer : Customer
    {
        public PoorCustomer(decimal money, List<IStock> wantedProducts, decimal priceTolerance) : base(money, wantedProducts, priceTolerance)
        {
        }
    }
}
