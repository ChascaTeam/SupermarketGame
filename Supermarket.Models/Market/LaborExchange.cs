namespace Supermarket.Models.Market
{
    using System.Collections.Generic;
    using Supermarket.Models.Interfaces;

    public class LaborExchange
    {
        public LaborExchange(List<IWorkForce> availableWorkers)
        {
            this.AvailableWorkers = availableWorkers;
        }

        public List<IWorkForce> AvailableWorkers { get; protected set; }

        public void Remove(IWorkForce worker)
        {
            this.AvailableWorkers.Remove(worker);
        }
    }
}
