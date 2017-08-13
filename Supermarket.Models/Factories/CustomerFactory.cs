using System.Collections.Generic;
using Supermarket.Models.CustomerTypes;
using Supermarket.Models.Interfaces;
using Supermarket.Models.RandomGenerators;

namespace Supermarket.Models.Factories
{
   public  class CustomerFactory
    {

        public Customer Get(int id)
        {
            RNDGenerator genarator = new DecimalGenerator();
            switch (id)
            {
                case 0:
                    return new VeryPoorCustomer(genarator.Rnd(0, 50), new List<IStock>(), 20);                                      
                case 1:
                    return new PoorCustomer(genarator.Rnd(0, 100), new List<IStock>(), 25);
                case 2:
                    return new AverageCustomer(genarator.Rnd(0, 150), new List<IStock>(), 30);
                case 3:
                    return new RichCustomer(genarator.Rnd(0, 200), new List<IStock>(), 40);
                case 4:
                    return new VeryRichCustomer(genarator.Rnd(0, 500), new List<IStock>(), 50);
                default:
                    return null;
            }
        }
    }
}
