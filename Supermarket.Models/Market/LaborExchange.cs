namespace Supermarket.Models.Market
{
    using System.Collections.Generic;
    using Supermarket.Models.Interfaces;

    public class LaborExchange
    {
        private List<IWorkForce> availableWorkers; 

        public LaborExchange(List<IWorkForce> availableWorkers)
        {
            this.AvailableWorkers = availableWorkers;
        }

        public List<IWorkForce> AvailableWorkers
        {
            get { return this.availableWorkers; }
            protected set { this.availableWorkers = value; }
        }

        public void Remove(IWorkForce worker)
        {
            this.AvailableWorkers.Remove(worker);
        }
    }
}
