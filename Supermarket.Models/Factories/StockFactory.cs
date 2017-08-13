using Supermarket.Models.StockTypes;

namespace Supermarket.Models.Factories
{
    public class StockFactory
    {
        public Stock Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new Alcohol();
                case 1:
                    return new DairyProducts();
                case 2:
                    return new Meat();
                case 3:
                    return new Vegetables();
                case 4:
                    return new Sweets();
                default:
                    return null;
            }
        }
    }
}
