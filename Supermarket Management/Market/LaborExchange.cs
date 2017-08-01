using System;
using System.Collections.Generic;

namespace Supermarket_Management
{
  public class LaborExchange : Generator
    {
        public LaborExchange(List<IWorkForce> availableProducts)
        {
            this.AvailableWorkers = availableProducts;
        }

        public List<IWorkForce> AvailableWorkers { get; protected set; }

        public void ShowAvailableWorkers()
        {
            throw new NotImplementedException();
        }
    }
}
