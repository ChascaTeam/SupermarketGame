using System.Collections.Generic;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.Interfaces
{
    public interface ICustomer

    {
        //Money can be random(to some extent) or hard coded
        decimal Money { get; }

        //How much a current client is willing to pay for a product.
        decimal PriceTolerance { get; }

        //Look at Customer for info
        List<IStock> WantedProducts { get; }

        //Should return total cost for the products that the client can and "want" to buy.
        void BuyWantedProducts(List<IStock> productsInStore);

        
       


    }
}
