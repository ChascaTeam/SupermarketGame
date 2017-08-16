namespace Supermarket.Models.Factories
{
    using Supermarket.Models.CustomerTypes;
    using Supermarket.Models.RandomGenerators;

    public class CustomerFactory
    {
        public Customer Get(int id)
        {
            RNDGenerator genarator = new IntGenerator();

            switch (id)
            {
                case 0:
                    return new VeryPoorCustomer(
                        genarator.Rnd(20, 100),
                        new StockGenerator().GenerateStock(0, 3),
                        genarator.Rnd(5, 7));
                case 1:
                    return new PoorCustomer(
                        genarator.Rnd(100, 150),
                        new StockGenerator().GenerateStock(0, 5),
                        genarator.Rnd(6, 8));
                case 2:
                    return new AverageCustomer(
                        genarator.Rnd(100, 200),
                        new StockGenerator().GenerateStock(0, 6),
                        genarator.Rnd(7, 9));
                case 3:
                    return new RichCustomer(
                        genarator.Rnd(150, 250),
                        new StockGenerator().GenerateStock(0, 7),
                        genarator.Rnd(9, 16));
                case 4:
                    return new VeryRichCustomer(
                        genarator.Rnd(200, 500),
                        new StockGenerator().GenerateStock(0, 10),
                        genarator.Rnd(11, 20));
                default:
                    return null;
            }
        }
    }
}
