namespace Supermarket.Models.WorkerTypes
{
    public class Expert : Worker
    {
        public Expert(string name, int customersPerDay, decimal salaryPerDay) : base(name, customersPerDay, salaryPerDay)
        {
        }
    }
}
