using System.Collections.Generic;
using Supermarket.Models.Interfaces;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.CustomerTypes
{
    public abstract class Customer : ICustomer
    {
        private decimal money;
        private List<Stock> wantedProducts;
        private decimal priceTolerance;

        protected Customer(decimal money, List<Stock> wantedProducts, decimal priceTolerance)
        {
            this.Money = money;
            this.WantedProducts = wantedProducts;
            this.PriceTolerance = priceTolerance;
            this.HasShoped = false;
        }

        public bool HasShoped { get; set; }

        public decimal Money
        {
            get => this.money;
            set => this.money = value;
        }

        public decimal PriceTolerance
        {
            get => this.priceTolerance;
            set => this.priceTolerance = value;
        }

        //randomly generated list of products from the StockGenerator
        public List<Stock> WantedProducts
        {
            get => this.wantedProducts;
            set => this.wantedProducts = value;
        }


    }
}
