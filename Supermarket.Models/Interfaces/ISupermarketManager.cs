using Supermarket.Models.Management;

namespace Supermarket.Models.Interfaces
{
    public interface ISupermarketManager
    {
        Warehouse Warehouse { get; }

        decimal CurrentCapital { get; }
    }
}
