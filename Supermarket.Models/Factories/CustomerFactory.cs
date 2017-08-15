using Supermarket.Models.CustomerTypes;
using Supermarket.Models.RandomGenerators;

namespace Supermarket.Models.Factories
{
    public class CustomerFactory
    {
        public Customer Get(int id)
        {
            RNDGenerator genarator = new IntGenerator();

            switch (id)
            {
                case 0:
                    return new VeryPoorCustomer(genarator.Rnd(0, 50), new StockGenerator().GenerateStock(0, 2), genarator.Rnd(2, 5));
                case 1:
                    return new PoorCustomer(genarator.Rnd(50, 100), new StockGenerator().GenerateStock(0, 3), genarator.Rnd(3, 6));
                case 2:
                    return new AverageCustomer(genarator.Rnd(100, 150), new StockGenerator().GenerateStock(0, 4), genarator.Rnd(4, 7));
                case 3:
                    return new RichCustomer(genarator.Rnd(150, 200), new StockGenerator().GenerateStock(0, 5), genarator.Rnd(6, 12));
                case 4:
                    return new VeryRichCustomer(genarator.Rnd(200, 500), new StockGenerator().GenerateStock(0, 6), genarator.Rnd(8, 16));
                default:
                    return null;
            }
        }
    }
}
