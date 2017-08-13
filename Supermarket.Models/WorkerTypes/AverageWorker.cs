namespace Supermarket.Models.WorkerTypes
{
    public class AverageWorker : Worker
    {
        public AverageWorker(string name) : base(name)
        {
            this.SalaryPerDay = 50;
            this.CustomersPerDay = 15;
        }
    }
}
