﻿namespace Supermarket.Models.RandomGenerators
{
    using System;
    using Supermarket.Models.Interfaces;

    public abstract class RNDGenerator : IRandomNumberGenerator
    {
        private readonly Random random = new Random();

        public int Rnd(int start, int end)
        {            
            var num = this.random.Next(start, end);

            return num;
        }
    }
}
