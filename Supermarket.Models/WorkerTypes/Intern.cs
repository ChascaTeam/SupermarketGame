namespace Supermarket.Models.WorkerTypes
{
    public class Intern : Worker
    {
        public Intern(string name, int customersPerDay, decimal salaryPerDay) : base(name, customersPerDay, salaryPerDay)
        {
        }
    }
}
