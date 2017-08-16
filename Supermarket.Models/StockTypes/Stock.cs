namespace Supermarket.Models.StockTypes
{
    using Supermarket.Models.Interfaces;

    public abstract class Stock : IStock
    {
        private string productName;
        private int quantity;
        private decimal price;

        protected Stock()
        {
            this.Quantity = 0;
            this.Price = 0;
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public void ChangePrice(decimal newPrice)
        {
            this.Price = newPrice;
        }
    }
}
