namespace Supermarket.Models.Interfaces
{
    using System.Collections.Generic;
    using Supermarket.Models.StockTypes;

    public interface ICustomer
    {
        //Money are random(to some extent)
        decimal Money { get; set; }

        //How much a current client is willing to pay for a product.
        decimal PriceTolerance { get; set; }

        //Look at Customer for info
        List<Stock> WantedProducts { get; set; }

        //Look at Customer for info
        bool HasShoped { get; set; }
    }
}
