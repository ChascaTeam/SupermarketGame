using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Supermarket.Management.Exceptions;

namespace Supermarket.Client.Forms
{
    public partial class LaborMarketMenuForm : Form
    {

        public LaborMarketMenuForm()
        {
            this.InitializeComponent();
            this.FillTextBoxes();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new MenuPlayForm());
            this.FillTextBoxes();
        }

        private void HireWorkersButton_Click(object sender, EventArgs e)
        {
            List<CheckBox> checkBoxs = new List<CheckBox> { this.checkBox0, this.checkBox1, this.checkBox2,
                this.checkBox3, this.checkBox4 };
            List<TextBox> textBoxs = new List<TextBox>{this.FirstWorkerText,this.SecondWorkerText,this.ThirdWorkerText,
                this.FourthWorkerText,this.FifthWorkerText};

            for (int i = 0; i < 5; i++)
            {
                if (checkBoxs[i].Checked && textBoxs[i].Text != "")
                {
                    try
                    {
                        if (Engine.workers.Count == 5)
                        {
                            throw new WorkerLimitException();
                        }
                        Engine.workers.Add(Engine.laborExchange.AvailableWorkers[i]);
                        textBoxs[i].Text = "";
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        return;
                    }           
                }
            }
        }

        private void FillTextBoxes()
        {
            for (int i = 0; i < Engine.laborExchange.AvailableWorkers.Count; i++)
            {

                if (Engine.workers.Contains(Engine.laborExchange.AvailableWorkers[i]))
                {
                    Engine.laborExchange.Remove(Engine.laborExchange.AvailableWorkers[i]);
                }
            }

            List<TextBox> textBoxs = new List<TextBox>{this.FirstWorkerText,this.SecondWorkerText,this.ThirdWorkerText,
                this.FourthWorkerText,this.FifthWorkerText};

            for (int i = 0; i < 5; i++)
            {
                textBoxs[i].Text = "";
                if (Engine.laborExchange.AvailableWorkers.Count - 1 >= i)
                {
                    textBoxs[i].Text = Engine.laborExchange.AvailableWorkers[i].ToString();
                }
            }
        }
    }
}
