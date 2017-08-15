using Supermarket.Models.Interfaces;

namespace Supermarket.Models.StockTypes
{
    public abstract class Stock : IStock
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        protected Stock()
        {
            this.Quantity = 0;
            this.Price = 0;
        }

        public void ChangePrice(decimal newPrice)
        {
            this.Price = newPrice;
        }
    }
}
