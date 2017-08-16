using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Supermarket.Management.Exceptions;

namespace Supermarket.Client.Forms
{
    public partial class StockMarketMenuForm : Form
    {
        public StockMarketMenuForm()
        {
            this.InitializeComponent();
            //Shows quantity for the products in the warehouse
            this.AlcoholTxt.Text = Engine.manager.Warehouse.StoredProducts[0].Quantity.ToString();
            this.DairyText.Text = Engine.manager.Warehouse.StoredProducts[1].Quantity.ToString();
            this.MeatText.Text = Engine.manager.Warehouse.StoredProducts[2].Quantity.ToString();
            this.SweetsText.Text = Engine.manager.Warehouse.StoredProducts[3].Quantity.ToString();
            this.VegetablesText.Text = Engine.manager.Warehouse.StoredProducts[4].Quantity.ToString();

            List<TextBox> quantityBoxes = new List<TextBox> { this.AlcoholQuantityText, this.DairyQuantityText, this.MeatQuantityText,
                this.SweetsQuantityText, this.VegetablesQuantityText };
            List<TextBox> priceBoxes = new List<TextBox> { this.AlcoholPriceText, this.DiaryPriceText, this.MeatPriceText,
                this.SweetsPriceText, this.VegetablesPriceText };

            for (int i = 0; i < 5; i++)
            {
                quantityBoxes[i].Text = Engine.stockExchange.AvailableStock[i].Quantity.ToString();
                priceBoxes[i].Text = Engine.stockExchange.AvailableStock[i].Price.ToString();
            }

        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new MenuPlayForm());
        }

        private void CalcTotalPriceButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.CheckInput();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            List<TextBox> buyQuantityBoxes = new List<TextBox> { this.AlcoholBuyText, this.DairyBuyText, this.MeatBuyText,
                this.SweetsBuyText, this.VegetablesBuyText };
            List<TextBox> priceBoxes = new List<TextBox> { this.AlcoholPriceText, this.DiaryPriceText, this.MeatPriceText,
                this.SweetsPriceText, this.VegetablesPriceText };
            decimal totalPrice = 0;
            decimal totalSpace = 0;

            for (int i = 0; i < 5; i++)
            {
                totalPrice += int.Parse(buyQuantityBoxes[i].Text) * int.Parse(priceBoxes[i].Text);
                totalSpace += int.Parse(buyQuantityBoxes[i].Text);
            }

            this.TotalPriceText.Text = totalPrice.ToString();
            this.WarehouseSpaceNeededText.Text = totalSpace.ToString();
            this.CurrentWarehouseSpsaceText.Text = (Engine.manager.Warehouse.WarehouseVolume - Engine.manager.Warehouse.FilledVolume()).ToString();
        }

        private void BuyProductsButton_Click(object sender, EventArgs e)
        {            
            List<TextBox> buyQuantityBoxes = new List<TextBox> { this.AlcoholBuyText, this.DairyBuyText, this.MeatBuyText,
                this.SweetsBuyText, this.VegetablesBuyText };
            List<TextBox> priceBoxes = new List<TextBox> { this.AlcoholPriceText, this.DiaryPriceText, this.MeatPriceText,
                this.SweetsPriceText, this.VegetablesPriceText };
            decimal totalPrice = 0;
            decimal totalSpace = 0;

            try
            {
                this.CheckInput();
                for (int i = 0; i < 5; i++)
                {
                    totalSpace += int.Parse(buyQuantityBoxes[i].Text);
                }
                if (totalSpace > Engine.manager.Warehouse.WarehouseVolume - Engine.manager.Warehouse.FilledVolume())
                {
                    throw new InvalidSizeException();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
          
            for (int i = 0; i < 5; i++)
            {
                Engine.manager.Warehouse.StoredProducts[i].Quantity += int.Parse(buyQuantityBoxes[i].Text);
                totalPrice += int.Parse(buyQuantityBoxes[i].Text) * int.Parse(priceBoxes[i].Text);
                Engine.stockExchange.AvailableStock[i].Quantity -= int.Parse(buyQuantityBoxes[i].Text);
            }

            Engine.manager.CurrentCapital -= totalPrice;

            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new StockMarketMenuForm());
        }

        private void CheckInput()
        {
            Regex reg = new Regex(@"^[0-9\.]+$");
            List<TextBox> input = new List<TextBox>{ this.AlcoholBuyText, this.DairyBuyText,
                this.MeatBuyText, this.SweetsBuyText, this.VegetablesBuyText };
            List<TextBox> quantityBoxes = new List<TextBox> { this.AlcoholQuantityText, this.DairyQuantityText, this.MeatQuantityText,
                this.SweetsQuantityText, this.VegetablesQuantityText };

            for (int i = 0; i < 5; i++)
            {
                if (input[i].Text == "")
                {
                    input[i].Text = "0";
                }
                if (!reg.IsMatch(input[i].Text))
                {
                    throw new InvalidInputException();
                }
                if (input[i].Text.Contains("-"))
                {
                    throw new InvalidNumberException();
                }
                if (int.Parse(quantityBoxes[i].Text) < int.Parse(input[i].Text))
                {
                    throw new WrongOrderException();
                }
            }
        }
    }
}
