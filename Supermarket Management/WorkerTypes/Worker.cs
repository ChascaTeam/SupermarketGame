namespace Supermarket_Management.WorkerTypes
{
    public abstract class Worker : IWorkForce
    {
        public string Name { get; set; }
        public int CustomersPerDay { get; set; }
        public decimal SalaryPerDay { get; set; }
    }
}
