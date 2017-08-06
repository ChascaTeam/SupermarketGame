using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Data;
using Supermarket_Management;

namespace Supermarket.Services
{
    public class WorkForceServices
    {
        //Hire worker
        public void AddWorker(IWorkForce worker)
        {
            WorkerData.Workers.Add(worker);
        }

        //Fire worker
        public void RemoveWorker(IWorkForce worker)
        {
            WorkerData.Workers.Remove(worker);
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
            return WorkerData.Workers;
        }
    }
}