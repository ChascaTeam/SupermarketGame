using System.Windows.Forms;

namespace Supermarket.Client.Forms
{
    public partial class WorkforceMenuForm : Form
    {
        public WorkforceMenuForm()
        {
            InitializeComponent();
        }

        private void WorkforceMenuForm_Load(object sender, System.EventArgs e)
        {

        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new MenuPlayForm());
        }
    }
}
