namespace Supermarket.Models.Management
{
    using Supermarket.Models.Interfaces;

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
            get { return this.currentCapital; }
            set { this.currentCapital = value; }
        }         
    }
}
