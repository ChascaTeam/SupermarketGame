namespace Supermarket.Models.Factories
{
    using Supermarket.Models.RandomGenerators;
    using Supermarket.Models.WorkerTypes;

    public class WorkerFactory
    {
        private readonly NameGenerator name = new NameGenerator();
        private readonly IntGenerator num = new IntGenerator();

        public Worker Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new Intern(this.name.GenerateName(), this.num.Rnd(7, 9), this.num.Rnd(40, 50));
                case 1:
                    return new LazyWorker(this.name.GenerateName(), this.num.Rnd(9, 12), this.num.Rnd(51, 59));
                case 2:
                    return new AverageWorker(this.name.GenerateName(), this.num.Rnd(12, 14), this.num.Rnd(57, 62));
                case 3:
                    return new Expert(this.name.GenerateName(), this.num.Rnd(16, 20), this.num.Rnd(70, 100));
                default:
                    return null;
            }
        }
    }
}
