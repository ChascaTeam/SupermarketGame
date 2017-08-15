using System.Collections.Generic;
using Supermarket.Models.StockTypes;

namespace Supermarket.Models.Interfaces
{
    public interface IWarehouse
    {
        List<Stock> StoredProducts { get; }

        int WarehouseVolume { get; }

        decimal WarehouseRent { get; }

        void IncreaseVolume(int volume);

        int FilledVolume();
    }
}
