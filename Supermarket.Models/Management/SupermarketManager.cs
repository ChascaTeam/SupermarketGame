namespace Supermarket.Models.Management
{
    using Supermarket.Models.Interfaces;

    public class SupermarketManager : ISupermarketManager
    {
        private decimal currentCapital;
        private Warehouse warehouse;

        public SupermarketManager(Warehouse warehouse, decimal currentCapital)
        {
            this.Warehouse = warehouse;
            this.CurrentCapital = currentCapital;
        }

        public Warehouse Warehouse
        {
            get { return this.warehouse; }
           protected set { this.warehouse = value; }
        }

        public decimal CurrentCapital
        {
            get { return this.currentCapital; }
            set { this.currentCapital = value; }
        }         
    }
}
