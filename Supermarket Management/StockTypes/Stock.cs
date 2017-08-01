namespace Supermarket_Management.StockTypes
{
    public abstract class Stock : IStock
    {
        public string ProductName { get; }
        public decimal Quantity { get; }
        public decimal Price { get; private set; }
        public int DaysTillExpiration { get; }
        public void ChangePrice(decimal newPrice)
        {
            this.Price = newPrice;
        }
    }
}
