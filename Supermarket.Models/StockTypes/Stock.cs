using Supermarket.Models.Interfaces;

namespace Supermarket.Models.StockTypes
{
    public abstract class Stock : IStock
    {
        public string ProductName { get; }
        public int Quantity { get; set; }
        public decimal Price { get; protected set; }
        public int DaysTillExpiration { get; }
        public void ChangePrice(decimal newPrice)
        {
            this.Price = newPrice;
        }
    }
}
