namespace Supermarket.Models.WorkerTypes
{
    public class AverageWorker : Worker
    {
        public AverageWorker(string name, int customersPerDay, decimal salaryPerDay) 
            : base(name, customersPerDay, salaryPerDay)
        {
        }
    }
}
