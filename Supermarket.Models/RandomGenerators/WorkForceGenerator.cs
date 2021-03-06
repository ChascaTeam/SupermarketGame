﻿namespace Supermarket.Models.RandomGenerators
{
    using System.Collections.Generic;
    using Supermarket.Models.Factories;
    using Supermarket.Models.Interfaces;

    public class WorkForceGenerator
    {
        private readonly WorkerFactory workerFactory = new WorkerFactory();
        private readonly IntGenerator generator = new IntGenerator();

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
