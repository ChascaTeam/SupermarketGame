using System.Windows.Forms;

namespace Supermarket.Client.Forms
{
    public partial class MenuPlayForm : Form
    {
        public MenuPlayForm()
        {
            InitializeComponent();
            this.textBox1.Text = Engine.daysPassed.ToString();
            this.CurrentMoneyText.Text = Engine.manager.CurrentCapital.ToString();
            this.IncomeText.Text = Engine.income.ToString();
        }

        private void NextDayButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;

            if (Engine.manager.CurrentCapital > 0)
            {   
                Engine.daysPassed++;               
                Engine.manager.CurrentCapital += Engine.income;
                Engine.manager.CurrentCapital -= (Engine.manager.Warehouse.WarehouseRent+Engine.manager.SalaryCostsPerDay());
                mainForm.SetContentHolderForm(new SummaryForm());
            }
            else
            {
                mainForm.SetContentHolderForm(new GameOverForm());
            }
        }

        private void WarehouseButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new WarehouseForm());
        }

        private void StockMarketButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new StockMarketMenuForm());
        }

        private void WorkforceButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new WorkforceMenuForm());
        }

        private void LaborMarketButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new LaborMarketMenuForm());
        }

        private void CurrentMoneyText_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
