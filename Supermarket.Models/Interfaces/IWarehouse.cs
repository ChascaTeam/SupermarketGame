namespace Supermarket.Models.Interfaces
{
    using System.Collections.Generic;
    using Supermarket.Models.StockTypes;

    public interface IWarehouse
    {
        List<Stock> StoredProducts { get; }

        int WarehouseVolume { get; }

        decimal WarehouseRent { get; }

        void IncreaseVolume(int volume);

        int FilledVolume();
    }
}
