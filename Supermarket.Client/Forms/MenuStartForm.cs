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
            this.InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {          
            Engine engine = new Engine();
            engine.Run();
            Engine.stockExchange = new StockExchange(new StockGenerator().GenerateStockForShop());
            Engine.laborExchange = new LaborExchange(new WorkForceGenerator().GenerateWorkersForHire());

            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new MenuPlayForm());
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
