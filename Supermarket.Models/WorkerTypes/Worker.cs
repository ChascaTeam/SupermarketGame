using Supermarket.Models.Interfaces;

namespace Supermarket.Models.WorkerTypes
{
    public abstract class Worker : IWorkForce
    {
        private string name;
        private int customersPerDay;
        private decimal salaryPerDay;

        public Worker(string name)
        {
            this.Name = name;
            this.CustomersPerDay = 50;
            this.SalaryPerDay = 20;
        }

        public string Name { get { return this.name; } set { this.name = value; } }
        public int CustomersPerDay { get { return this.customersPerDay; } set { this.customersPerDay = value; } }
        public decimal SalaryPerDay { get { return this.salaryPerDay; } set { this.salaryPerDay = value; } }
    }
}
