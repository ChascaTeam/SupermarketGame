namespace Supermarket.Models.Interfaces
{
    using Supermarket.Models.Management;

    public interface ISupermarketManager
    {
        Warehouse Warehouse { get; }

        decimal CurrentCapital { get; }
    }
}
