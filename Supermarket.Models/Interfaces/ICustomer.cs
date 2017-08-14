using System.Collections.Generic;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.Interfaces
{
    public interface ICustomer

    {
        //Money can be random(to some extent) or hard coded
        decimal Money { get; set; }

        //How much a current client is willing to pay for a product.
        decimal PriceTolerance { get; set; }

        //Look at Customer for info
        List<Stock> WantedProducts { get; set; }

        bool HasShoped { get; set; }
    }
}
