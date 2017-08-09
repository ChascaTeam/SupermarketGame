namespace Supermarket.Models.WorkerTypes
{
    public class Intern : Worker
    {
        public Intern(string name) : base(name)
        {
            this.SalaryPerDay -= 10;
            this.CustomersPerDay -= 20;
        }
    }
}
