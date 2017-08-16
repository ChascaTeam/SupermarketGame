using System;
using System.Windows.Forms;

namespace Supermarket.Client.Forms
{
    public partial class GameOverForm : Form
    {
        public GameOverForm()
        {
            this.InitializeComponent();
        }

        private void TryAgainButton_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new MenuStartForm());
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
