namespace Supermarket.Models.Interfaces
{
    public interface IStock
    {
        //Everything here explains itself. No need for additional explanation.

        string ProductName { get; }

        int Quantity { get;}

        decimal Price { get; }

        void ChangePrice(decimal newPrice);
    }
}
