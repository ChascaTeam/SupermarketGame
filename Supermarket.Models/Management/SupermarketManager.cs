using Supermarket.Models.Interfaces;

namespace Supermarket.Models.Management
{
    public class SupermarketManager : ISupermarketManager
    {
        private decimal currentCapital;

        public SupermarketManager(Warehouse warehouse, decimal currentCapital)
        {
            this.Warehouse = warehouse;
            this.CurrentCapital = currentCapital;
        }

        public Warehouse Warehouse { get; }

        public decimal CurrentCapital
        {
            get => this.currentCapital;
            set => this.currentCapital = value;
        }         
    }
}
