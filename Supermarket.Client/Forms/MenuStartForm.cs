using System;
using System.Windows.Forms;
using Supermarket.Models.Market;
using Supermarket.Models.RandomGenerators;

namespace Supermarket.Client.Forms
{
    public partial class MenuStartForm : Form
    {
        public MenuStartForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new MenuPlayForm());
            Engine.stockExchange = new StockExchange(new StockGenerator().GenerateStockForShop());
            Engine.laborExchange = new LaborExchange(new WorkForceGenerator().GenerateWorkersForHire());
        }

        private void GameInfo_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new InfoMenuForm());
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
