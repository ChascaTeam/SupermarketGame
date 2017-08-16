namespace Supermarket.Models.CustomerTypes
{
    using System.Collections.Generic;
    using Supermarket.Models.StockTypes;

    public class PoorCustomer : Customer
    {
        public PoorCustomer(decimal money, List<Stock> wantedProducts, decimal priceTolerance)
            : base(money, wantedProducts, priceTolerance)
        {
        }
    }
}
