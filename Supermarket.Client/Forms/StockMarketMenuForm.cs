using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Supermarket.Management.Market;
using Supermarket.Models.RandomGenerators;

namespace Supermarket.Client.Forms
{
    public partial class StockMarketMenuForm : Form
    {
        public StockMarketMenuForm()
        {
            InitializeComponent();
            this.AlcoholTxt.Text = Engine.manager.Warehouse.StoredProducts[0].Quantity.ToString();
            this.DairyText.Text = Engine.manager.Warehouse.StoredProducts[1].Quantity.ToString();
            this.MeatText.Text = Engine.manager.Warehouse.StoredProducts[2].Quantity.ToString();
            this.SweetsText.Text = Engine.manager.Warehouse.StoredProducts[3].Quantity.ToString();
            this.VegetablesText.Text = Engine.manager.Warehouse.StoredProducts[4].Quantity.ToString();


            List<TextBox> quantityBoxes = new List<TextBox> { this.AlcoholQuantityText, this.DairyQuantityText, this.MeatQuantityText, this.SweetsQuantityText, this.VegetablesQuantityText };
            List<TextBox> priceBoxes = new List<TextBox> { this.AlcoholPriceText, this.DiaryPriceText, this.MeatPriceText, this.SweetsPriceText, this.VegetablesPriceText };

            for (int i = 0; i < 5; i++)
            {
                quantityBoxes[i].Text = Engine.stockExchange.AvailableStock[i].Quantity.ToString();
                priceBoxes[i].Text = Engine.stockExchange.AvailableStock[i].Price.ToString();
            }

        }

        private void AlcoholTxt_TextChanged(object sender, System.EventArgs e)
        {

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
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            List<TextBox> quantityBoxes = new List<TextBox> { this.AlcoholBuyText, this.DairyBuyText, this.MeatBuyText, this.SweetsBuyText, this.VegetablesBuyText };
            List<TextBox> priceBoxes = new List<TextBox> { this.AlcoholPriceText, this.DiaryPriceText, this.MeatPriceText, this.SweetsPriceText, this.VegetablesPriceText };
            decimal totalPrice = 0;
            decimal totalSpace = 0;

            for (int i = 0; i < 5; i++)
            {
                totalPrice += int.Parse(quantityBoxes[i].Text) * int.Parse(priceBoxes[i].Text);
                totalSpace += int.Parse(quantityBoxes[i].Text);
            }

            this.TotalPriceText.Text = totalPrice.ToString();
            this.WarehouseSpaceNeededText.Text = totalSpace.ToString();
            this.CurrentWarehouseSpsaceText.Text = (Engine.manager.Warehouse.WarehouseVolume - Engine.manager.Warehouse.FilledVolume()).ToString();

        }

        private void BuyProductsButton_Click(object sender, EventArgs e)
        {

            List<TextBox> quantityBoxes = new List<TextBox> { this.AlcoholBuyText, this.DairyBuyText, this.MeatBuyText, this.SweetsBuyText, this.VegetablesBuyText };
            List<TextBox> priceBoxes = new List<TextBox> { this.AlcoholPriceText, this.DiaryPriceText, this.MeatPriceText, this.SweetsPriceText, this.VegetablesPriceText };

            decimal totalPrice = 0;
            decimal totalSpace = 0;
            try
            {
                this.CheckInput();
                for (int i = 0; i < 5; i++)
                {
                    totalSpace += int.Parse(quantityBoxes[i].Text);
                }
                if (totalSpace > Engine.manager.Warehouse.WarehouseVolume - Engine.manager.Warehouse.FilledVolume())
                {
                    throw new ArgumentException("Not enough space!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }


            for (int i = 0; i < 5; i++)
            {
                Engine.manager.Warehouse.StoredProducts[i].Quantity += int.Parse(quantityBoxes[i].Text);
                totalPrice += int.Parse(quantityBoxes[i].Text) * int.Parse(priceBoxes[i].Text);
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
            List<TextBox> quantityBoxes = new List<TextBox> { this.AlcoholQuantityText, this.DairyQuantityText, this.MeatQuantityText, this.SweetsQuantityText, this.VegetablesQuantityText };

            for (int i = 0; i < 5; i++)
            {
                if (input[i].Text == "")
                {
                    input[i].Text = "0";
                }
                if (!reg.IsMatch(input[i].Text))
                {
                    throw new ArgumentException("Positive numbers only!");
                }
                if (int.Parse(quantityBoxes[i].Text) < int.Parse(input[i].Text))
                {
                    throw new ArgumentException("Cant buy more than its offered!");
                }

            }
        }

        private void WarehouseSpaceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
