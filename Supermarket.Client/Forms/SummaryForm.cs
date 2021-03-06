﻿using System.Linq;
using System.Windows.Forms;
using Supermarket.Models.Market;
using Supermarket.Models.RandomGenerators;


namespace Supermarket.Client.Forms
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            this.InitializeComponent();
            this.DayText.Text = (Engine.daysPassed - 1) + ", " + Engine.dayCounter.GetDayOfWeek(Engine.daysPassed - 1);
            this.RevenueText.Text = Engine.income.ToString();
            this.WagesText.Text = this.SalaryCostsPerDay().ToString();
            this.RentText.Text = Engine.manager.Warehouse.WarehouseRent.ToString();
            this.TotalText.Text = (Engine.income - (Engine.manager.Warehouse.WarehouseRent + this.SalaryCostsPerDay())).ToString();
            this.SatisfiedClientsText.Text = Engine.counter.SatisfiedNumber.ToString();
            this.UnsatisfiedClientsText.Text = Engine.counter.UnsatisfiedNumber.ToString();
        }

        private void ContinueButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;

            if (Engine.manager.CurrentCapital > 0)
            {
                Engine.stockExchange = new StockExchange(new StockGenerator().GenerateStockForShop());
                Engine.laborExchange = new LaborExchange(new WorkForceGenerator().GenerateWorkersForHire());
                Engine.counter.Clear();
                Engine.PreviousDayIncome = (Engine.income - (Engine.manager.Warehouse.WarehouseRent + this.SalaryCostsPerDay())); 
                Engine.income = 0;
                mainForm.SetContentHolderForm(new MenuPlayForm());
            }
            else
            {
                mainForm.SetContentHolderForm(new GameOverForm());
            }
        }

        private decimal SalaryCostsPerDay()
        {
            return Engine.workers.Sum(w => w.SalaryPerDay);
        }
    }
}
