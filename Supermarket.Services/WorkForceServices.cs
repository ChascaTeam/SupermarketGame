namespace Supermarket.Services
{
    using System.Collections.Generic;
    using Supermarket.Data;
    using Supermarket.Models.Interfaces;

    public class WorkForceServices : WorkerData
    {
        // Hire worker
        public void AddWorker(IWorkForce worker)
        {
            Workers.Add(worker);
        }

        // Fire worker
        public void RemoveWorker(IWorkForce worker)
        {
            Workers.Remove(worker);
        }

        public void IncreaseSalary(IWorkForce worker, decimal increaseBy)
        {
            worker.SalaryPerDay += increaseBy;
        }

        public void DecreaseSalary(IWorkForce worker, decimal decreaseBy)
        {
            worker.SalaryPerDay -= decreaseBy;
        }

        public IList<IWorkForce> GetAllWorkers()
        {
            return Workers;
        }
    }
}