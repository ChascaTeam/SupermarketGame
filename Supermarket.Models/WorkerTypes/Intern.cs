namespace Supermarket.Models.WorkerTypes
{
    public class Intern : Worker
    {
        public Intern(string name) : base(name)
        {
            this.SalaryPerDay = 25;
            this.CustomersPerDay = 5;
        }
    }
}
