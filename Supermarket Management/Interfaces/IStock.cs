namespace Supermarket_Management
{
    public interface IStock
    {
        //Everything here explains itself. No need for additional explanation.
        string ProductName { get; }
        decimal Quantity { get; }
        decimal Price { get; }
        int DaysTillExpiration { get; }
        void ChangePrice(decimal newPrice);
    }
}
