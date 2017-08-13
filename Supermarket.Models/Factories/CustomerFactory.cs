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
          Generator genarator = new Generator();
            switch (id)
            {
                case 0:
                    return new VeryPoorCustomer(genarator.rnd(0, 50), new List<IStock>(), 20);                                      
                case 1:
                    return new PoorCustomer(genarator.rnd(0, 100), new List<IStock>(), 25);
                case 2:
                    return new AverageCustomer(genarator.rnd(0, 150), new List<IStock>(), 30);
                case 3:
                    return new RichCustomer(genarator.rnd(0, 200), new List<IStock>(), 40);
                case 4:
                    return new VeryRichCustomer(genarator.rnd(0, 500), new List<IStock>(), 50);
                default:
                    return null;
            }
        }
    }
}
