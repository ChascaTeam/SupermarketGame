namespace Supermarket.Models.WorkerTypes
{
    public class Expert : Worker
    {
        public Expert(string name) : base(name)
        {
            this.SalaryPerDay = 80;
            this.CustomersPerDay = 20;
        }
    }
}
