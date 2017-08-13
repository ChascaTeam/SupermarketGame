using System;
using System.Windows.Forms;
using Supermarket.Management;

namespace Supermarket.Client
{
    public partial class MenuStartForm : Form
    {
        public MenuStartForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, System.EventArgs e)
        {
            Engine engine = new Engine();
            engine.Run();
            Environment.Exit(0);
        }
    }
}
