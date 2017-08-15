using System.Collections.Generic;
using System.Windows.Forms;

namespace Supermarket.Client.Forms
{
    public partial class WorkforceMenuForm : Form
    {
        public WorkforceMenuForm()
        {
            this.InitializeComponent();
            this.FillTextBoxes();
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new MenuPlayForm());
            this.FillTextBoxes();
        }

        private void FireWorkersButton_Click(object sender, System.EventArgs e)
        {
            List<CheckBox> checkBoxs = new List<CheckBox> { this.checkBox0, this.checkBox1, this.checkBox2, this.checkBox3, this.checkBox4 };
            List<TextBox> textBoxs = new List<TextBox>{this.FirstWorkerText,this.SecondWorkerText,this.ThirdWorkerText,
                this.FourthWorkerText,this.FifthWorkerText};
            var changedVal = 0;

            for (int i = 0; i < 5; i++)
            {
                if (checkBoxs[i].Checked && textBoxs[i].Text != "")
                {                                            
                        Engine.workers.Remove(Engine.workers[i +changedVal]);
                        changedVal--;
                        textBoxs[i].Text = "";                                       
                }
            }
        }

        private void FillTextBoxes()
        {
            
            List<TextBox> textBoxs = new List<TextBox>{this.FirstWorkerText,this.SecondWorkerText,this.ThirdWorkerText,
                this.FourthWorkerText,this.FifthWorkerText};

            for (int i = 0; i < 5; i++)
            {
                textBoxs[i].Text = "";
                if (Engine.workers.Count - 1 >= i)
                {
                    textBoxs[i].Text = Engine.workers[i].ToString();
                }
            }
        }
    }
}
