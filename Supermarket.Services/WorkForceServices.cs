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
            this.Workers.Add(worker);
        }

        // Fire worker
        public void RemoveWorker(IWorkForce worker)
        {
            this.Workers.Remove(worker);
        }

        //Not implemented
        public void IncreaseSalary(IWorkForce worker, decimal increaseBy)
        {
            worker.SalaryPerDay += increaseBy;
        }

        //Not implemented
        public void DecreaseSalary(IWorkForce worker, decimal decreaseBy)
        {
            worker.SalaryPerDay -= decreaseBy;
        }

        public IList<IWorkForce> GetAllWorkers()
        {
            return this.Workers;
        }
    }
}