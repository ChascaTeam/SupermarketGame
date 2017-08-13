using System;
using System.Collections.Generic;
using System.Linq;
using Supermarket.Models.Interfaces;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.CustomerTypes
{
    public abstract class Customer : ICustomer
    {
        private decimal money;
        private List<IStock> wantedProducts = new List<IStock>();
        private decimal priceTolerance;

        protected Customer(decimal money, List<IStock> wantedProducts, decimal priceTolerance)
        {
            this.Money = money;
            this.WantedProducts = wantedProducts;
            this.PriceTolerance = priceTolerance;
        }

        public decimal Money
        {
            get => this.money;
            protected set => this.money = value;
        }

        public decimal PriceTolerance
        {
            get => this.money;
            protected set => this.money = value;
        }

        //randomly generated list of products from the StockGenerator
        public List<IStock> WantedProducts
        {
            get => this.wantedProducts;
            protected set => this.wantedProducts = value;
        }

        public void BuyWantedProducts(List<IStock> productsInStore)
        {
            decimal quantity;
            decimal spentMoney = 0m;

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (productsInStore[i].Equals(this.WantedProducts[j]))
                    {
                        if (productsInStore[i].Quantity >= this.WantedProducts[j].Quantity)
                        {
                            quantity = this.WantedProducts[j].Quantity;

                            spentMoney += this.SpentMoney(quantity, productsInStore[i]);

                        }
                        else
                        {
                            quantity = productsInStore[i].Quantity;

                            spentMoney += this.SpentMoney(quantity, productsInStore[i]);
                        }

                    }

                }
            }
        }

        private decimal SpentMoney(decimal quantity, IStock product)
        {
            decimal spentMoney = 0m;

            if (product.Price <= this.PriceTolerance)
            {
                for (int k = 0; k < quantity; k++)
                {
                    if (this.Money > product.Price)
                    {
                        spentMoney += product.Price;
                        this.Money -= product.Price;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return spentMoney;
        }
    }
}
