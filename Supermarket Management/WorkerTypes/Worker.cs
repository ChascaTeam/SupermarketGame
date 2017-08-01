namespace Supermarket_Management.WorkerTypes
{
    public abstract class Worker : IWorkForce
    {
        public string Name { get; }
        public int ClientsPerDay { get; }
        public decimal SalaryPerDay { get; }
    }
}
