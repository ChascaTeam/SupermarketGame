namespace Supermarket_Management
{ 
    public interface IWorkForce
    {
        //Name should be unique
        string Name { get; set; }
        //The amount of clients the worker can serve for a day
        int CustomersPerDay { get; set; }

        decimal SalaryPerDay { get; set; }
    }
}
