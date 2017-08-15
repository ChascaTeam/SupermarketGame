using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Supermarket.Management.Market;
using Supermarket.Models.Interfaces;
using Supermarket.Models.RandomGenerators;
using Supermarket.Models.StockTypes;

namespace Supermarket.Client.Forms
{
    public partial class MenuPlayForm : Form
    {

        public MenuPlayForm()
        {
            InitializeComponent();            
            this.textBox1.Text = Engine.daysPassed.ToString();
            this.CurrentMoneyText.Text = Engine.manager.CurrentCapital.ToString();
            this.IncomeText.Text = Engine.income.ToString();
        }

        private void NextDayButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            Engine.daysPassed++;
            this.CreateCustomersData();
            this.CalculateWorkersPower();

            foreach (var customer in Engine.customers)
            {
                this.CustomersShopping(Engine.manager.Warehouse.StoredProducts, customer);
            }

            Engine.manager.CurrentCapital += Engine.income;
            Engine.manager.CurrentCapital -= (Engine.manager.Warehouse.WarehouseRent + this.SalaryCostsPerDay());
            mainForm.SetContentHolderForm(new SummaryForm());
        }

        private void WarehouseButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new WarehouseForm());
        }

        private void StockMarketButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new StockMarketMenuForm());
        }

        private void WorkforceButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new WorkforceMenuForm());
        }

        private void LaborMarketButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)(this).Parent.Parent;
            mainForm.SetContentHolderForm(new LaborMarketMenuForm());
        }

        private void CurrentMoneyText_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private decimal SalaryCostsPerDay()
        {
            return Engine.workers.Sum(w => w.SalaryPerDay);
        }

        private void CreateCustomersData()
        {
            Engine.customers = new CustomerGenerator().GenerateCustomers();
        }
        private void CalculateWorkersPower()
        {

            int numOfClients = 0;

            foreach (var worker in Engine.workers)
            {
                numOfClients += worker.CustomersPerDay;
            }

            if (numOfClients < Engine.customers.Count)
            {
                Engine.counter.UnsatisfiedNumber += Engine.customers.Count - numOfClients;
                if (numOfClients == 0)
                {
                    Engine.customers.Clear();
                }
                else
                {
                    Engine.customers = Engine.customers.Take(numOfClients).ToList();
                }

            }

        }

        private void CustomersShopping(List<Stock> productsInStore, ICustomer customer)
        {
            decimal quantity;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (productsInStore[i].ProductName.Equals(customer.WantedProducts[j].ProductName))
                    {
                        if (productsInStore[i].Quantity >= customer.WantedProducts[j].Quantity)
                        {
                            quantity = customer.WantedProducts[j].Quantity;
                            Engine.income += this.SpentMoney(quantity, productsInStore[i], customer, i);
                            if (customer.WantedProducts[j].Quantity != 0)
                            {
                                customer.HasShoped = true;
                            }
                            
                        }
                        else
                        {
                            quantity = productsInStore[i].Quantity;
                            Engine.income += this.SpentMoney(quantity, productsInStore[i], customer, i);
                            if (customer.WantedProducts[j].Quantity != 0)
                            {
                                customer.HasShoped = true;
                            }
                        }                                              
                    }
                }

                if (customer.HasShoped)
                {
                    Engine.counter.AddSatisfied();
                }
                else
                {
                    Engine.counter.AddUnsatisfied();
                }
                customer.HasShoped = false;
            }
        }

        private decimal SpentMoney(decimal quantity, Stock product, ICustomer customer, int i)
        {
            decimal spentMoney = 0m;

            if (product.Price <= customer.PriceTolerance)
            {
                for (int k = 0; k < quantity; k++)
                {
                    if (customer.Money > product.Price)
                    {
                        spentMoney += product.Price;
                        customer.Money -= product.Price;
                        Engine.manager.Warehouse.StoredProducts[i].Quantity--;

                    }
                    else
                    {
                        break;
                    }
                }
            }

            return spentMoney;
        }
    }
}
