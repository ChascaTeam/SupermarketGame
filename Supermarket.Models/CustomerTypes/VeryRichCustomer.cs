namespace Supermarket.Models.CustomerTypes
{
    using System.Collections.Generic;
    using Supermarket.Models.StockTypes;

    public class VeryRichCustomer : Customer
    {
        public VeryRichCustomer(decimal money, List<Stock> wantedProducts, decimal priceTolerance)
            : base(money, wantedProducts, priceTolerance)
        {
        }
    }
}
