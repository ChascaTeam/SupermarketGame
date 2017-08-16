namespace Supermarket.Data
{
    using System.Collections.Generic;
    using Supermarket.Data.Interfaces;
    using Supermarket.Models.Interfaces;

    public class WorkerData : IWorkerData
    {
        private IList<IWorkForce> workers;

        public WorkerData()
        {
            this.Workers = new List<IWorkForce>();
        }

        public IList<IWorkForce> Workers
        {
            get { return this.workers; }
            set { this.workers = value; }
        }
    }
}