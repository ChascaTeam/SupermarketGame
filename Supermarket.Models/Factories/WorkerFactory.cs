using Supermarket.Models.RandomGenerators;
using Supermarket.Models.WorkerTypes;

namespace Supermarket.Models.Factories
{
    public class WorkerFactory
    {
        private readonly NameGenerator name = new NameGenerator();

        public Worker Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new Intern(this.name.GenerateName());
                case 1:
                    return new LazyWorker(this.name.GenerateName());
                case 2:
                    return new AverageWorker(this.name.GenerateName());
                case 3:
                    return new Expert(this.name.GenerateName());
                default:
                    return null;
            }
        }
    }

}
