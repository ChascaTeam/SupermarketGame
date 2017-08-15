using System;
using System.Collections.Generic;
using Supermarket.Models.Interfaces;
using Supermarket.Models.RandomGenerators;

namespace Supermarket.Management.Market
{
  public class LaborExchange : RNDGenerator
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
