using System.Collections.Generic;
using System.Windows.Forms;
using Supermarket.Management.Market;
using Supermarket.Models.Interfaces;
using Supermarket.Models.RandomGenerators;

namespace Supermarket.Client.Forms
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
            this.DayText.Text = (Engine.daysPassed -1).ToString();
            this.WagesText.Text = Engine.manager.SalaryCostsPerDay().ToString();
            this.RentText.Text = Engine.manager.Warehouse.WarehouseRent.ToString();
            this.TotalText.Text = (Engine.manager.Warehouse.WarehouseRent + Engine.manager.SalaryCostsPerDay()).ToString();
            this.SatisfiedClientsText.Text = Engine.counter.SatisfiedNumber.ToString();
            this.UnsatisfiedClientsText.Text = Engine.counter.UnsatisfiedNumber.ToString();
        }

        private void ContinueButton_Click(object sender, System.EventArgs e)
        {
            Engine.laborExchange = new LaborExchange(new WorkForceGenerator().GenerateWorkersForHire());
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new MenuPlayForm());
        }

        private void SummaryForm_Load(object sender, System.EventArgs e)
        {

        }

        private void UnsatisfiedClientsText_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void RentText_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
