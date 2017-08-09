namespace Supermarket.Models.WorkerTypes
{
    public class Expert : Worker
    {
        public Expert(string name) : base(name)
        {
            this.SalaryPerDay += 10;
            this.CustomersPerDay += 15;
        }
    }
}
