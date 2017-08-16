using System.Windows.Forms;

namespace Supermarket.Client.Forms
{
    public partial class InfoMenuForm : Form
    {
        public InfoMenuForm()
        {
            this.InitializeComponent();
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new MenuStartForm());
        }
    }
}
