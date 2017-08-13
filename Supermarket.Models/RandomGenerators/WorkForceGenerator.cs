using System.Collections.Generic;
using Supermarket.Models.Factories;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.RandomGenerators
{
   public class WorkForceGenerator : RNDGenerator
    {
        private WorkerFactory workerFactory = new WorkerFactory();
        private DecimalGenerator generator = new DecimalGenerator();

        public List<IWorkForce> GenerateWorkersForHire()
        {           
            List<IWorkForce> workersForHire = new List<IWorkForce>();

            for (int i = 0; i < 5; i++)
            {
                workersForHire.Add(this.workerFactory.Get(base.Rnd(0, 3)));
            }
            return workersForHire;
        }

    }
}
