using System.Collections.Generic;
using Supermarket.Models.Factories;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.RandomGenerators
{
   public class WorkForceGenerator
    {
        private WorkerFactory workerFactory = new WorkerFactory();
        private IntGenerator generator = new IntGenerator();

        public List<IWorkForce> GenerateWorkersForHire()
        {           
            List<IWorkForce> workersForHire = new List<IWorkForce>();

            for (int i = 0; i < 5; i++)
            {
                workersForHire.Add(this.workerFactory.Get(this.generator.Rnd(0, 3)));
            }
            return workersForHire;
        }

    }
}
