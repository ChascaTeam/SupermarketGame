namespace Supermarket.Models.CustomerTypes
{
    using System.Collections.Generic;
    using Supermarket.Models.StockTypes;

    public class VeryPoorCustomer : Customer
    {
        public VeryPoorCustomer(decimal money, List<Stock> wantedProducts, decimal priceTolerance)
            : base(money, wantedProducts, priceTolerance)
        {
        }
    }
}
