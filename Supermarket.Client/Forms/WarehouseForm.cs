﻿using System;
using System.Windows.Forms;

namespace Supermarket.Client.Forms
{
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();

            this.AlcoholTxt.Text = Engine.manager.Warehouse.StoredProducts[0].Quantity.ToString();
            this.DairyText.Text = Engine.manager.Warehouse.StoredProducts[1].Quantity.ToString();
            this.MeatText.Text = Engine.manager.Warehouse.StoredProducts[2].Quantity.ToString();
            this.SweetsText.Text = Engine.manager.Warehouse.StoredProducts[3].Quantity.ToString();
            this.VegetablesText.Text = Engine.manager.Warehouse.StoredProducts[4].Quantity.ToString();
            this.AlcoholPriceText.Text = Engine.manager.Warehouse.StoredProducts[0].Price.ToString();
            this.DairyPriceText.Text = Engine.manager.Warehouse.StoredProducts[1].Price.ToString();
            this.MeatPriceText.Text = Engine.manager.Warehouse.StoredProducts[2].Price.ToString();
            this.SweetsPriceText.Text = Engine.manager.Warehouse.StoredProducts[3].Price.ToString();
            this.VegetablesPriceText.Text = Engine.manager.Warehouse.StoredProducts[4].Price.ToString();
            this.RentPerDayText.Text = Engine.manager.Warehouse.WarehouseRent.ToString();
            this.TotalSpaceText.Text = Engine.manager.Warehouse.WarehouseVolume.ToString();
            this.LeftSpaceText.Text = (Engine.manager.Warehouse.WarehouseVolume - Engine.manager.Warehouse.FilledVolume()).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AlcoholTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangePricesButton_Click(object sender, EventArgs e)
        {

            Engine.manager.Warehouse.StoredProducts[0].Price =  decimal.Parse(this.AlcoholPriceText.Text);
            Engine.manager.Warehouse.StoredProducts[1].Price = decimal.Parse(this.DairyPriceText.Text);
            Engine.manager.Warehouse.StoredProducts[2].Price = decimal.Parse(this.MeatPriceText.Text);
            Engine.manager.Warehouse.StoredProducts[3].Price = decimal.Parse(this.SweetsPriceText.Text);
            Engine.manager.Warehouse.StoredProducts[4].Price = decimal.Parse(this.VegetablesPriceText.Text);
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new WarehouseForm());


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new MenuPlayForm());
        }




    }
}
