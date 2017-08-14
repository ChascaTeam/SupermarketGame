using System;
using System.Windows.Forms;

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


            Engine engine = new Engine();
            engine.Run();
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
