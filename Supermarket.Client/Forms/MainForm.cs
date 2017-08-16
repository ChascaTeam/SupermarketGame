using System.Windows.Forms;

namespace Supermarket.Client.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
            this.SetContentHolderForm(new MenuStartForm());
        }
        public void SetContentHolderForm(Form a)
        {
            a.TopLevel = false;
            this.ContentHolder.Controls.Clear();
            this.ContentHolder.Controls.Add(a);

            foreach (Control aControl in a.Controls)
            {
                aControl.Visible = true;
            }
            a.Show();
        }
    }
}
