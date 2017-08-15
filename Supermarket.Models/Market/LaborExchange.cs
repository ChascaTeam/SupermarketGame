using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.Market
{
  public class LaborExchange
    {
        public LaborExchange(List<IWorkForce> availableProducts)
        {
            this.AvailableWorkers = availableProducts;
        }

        public List<IWorkForce> AvailableWorkers { get; protected set; }

        public void Remove(IWorkForce worker)
        {
            this.AvailableWorkers.Remove(worker);
        }
    }
}
