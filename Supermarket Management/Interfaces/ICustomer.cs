using System.Collections.Generic;

namespace Supermarket_Management
{
    public interface ICustomer

    {
        //Money can be random(to some extent) or hard coded
        decimal MoneyInCash { get; }
        decimal MoneyInCard { get; }

        //Look at Customer for info
        List<IStock> WantedProducts { get; }

        //Should return total cost for the products that the client can and "want" to buy.
        decimal BuyWantedProducts();

        //How much a current client (above or below the preset price) is willing to pay.
        void PriceTolerance();


    }
}
