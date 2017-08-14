namespace Supermarket.Models.WorkerTypes
{
    public class LazyWorker : Worker
    {
        public LazyWorker(string name, int customersPerDay, decimal salaryPerDay) : base(name, customersPerDay, salaryPerDay)
        {
        }
    }
}
