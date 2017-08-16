namespace Supermarket.Models.CustomerTypes
{
    using System.Collections.Generic;
    using Supermarket.Models.StockTypes;

    public class AverageCustomer : Customer
    {        
        public AverageCustomer(decimal money, List<Stock> wantedProducts, decimal priceTolerance)
            : base(money, wantedProducts, priceTolerance)
        {           
        }
    }
}
