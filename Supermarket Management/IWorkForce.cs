namespace Supermarket_Management
{ 
    public interface IWorkForce
    {
        //Name should be unique
        string Name { get; }
        //The amount of clients the worker can serve for a day
        int ClientsPerDay { get; }

        decimal SalaryPerDay { get; }
    }
}
