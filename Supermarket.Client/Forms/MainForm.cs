using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.Client.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void ContentHolder_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
