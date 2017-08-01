namespace Supermarket_Management.WorkerTypes
{
    public abstract class Worker : IWorkForce
    {
        public string Name { get; }
        public int CustomersPerDay { get; }
        public decimal SalaryPerDay { get; }
    }
}
