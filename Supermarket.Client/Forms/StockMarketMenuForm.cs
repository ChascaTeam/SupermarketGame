using System.Windows.Forms;

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
        }

        private void AlcoholTxt_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new MenuPlayForm());
        }
    }
}
