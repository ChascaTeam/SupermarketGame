using System;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.RandomGenerators
{
   public abstract class RNDGenerator : IRandomNumberGenerator
    {
        private readonly Random random = new Random();

        public int Rnd(int start, int end)
        {            
            var num = random.Next(start, end);

            return num;
        }
    }
}
