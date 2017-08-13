using System;
using Supermarket.Models.Interfaces;

namespace Supermarket.Models.RandomGenerators
{
   public abstract class RNDGenerator : IRandomNumberGenerator
    {
        private readonly Random random = new Random();

        public int rnd(int start, int end)
        {            
            var num = int.Parse(random.Next(start, end).ToString());

            return num;
        }
    }
}
