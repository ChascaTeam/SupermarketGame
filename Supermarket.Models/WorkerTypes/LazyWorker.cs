namespace Supermarket.Models.WorkerTypes
{
    public class LazyWorker : Worker
    {
        public LazyWorker(string name) : base(name)
        {
            this.SalaryPerDay -= 5;
            this.CustomersPerDay -= 10;
        }
    }
}
