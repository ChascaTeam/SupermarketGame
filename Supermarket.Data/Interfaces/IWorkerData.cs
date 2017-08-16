namespace Supermarket.Data.Interfaces
{
    using System.Collections.Generic;
    using Supermarket.Models.Interfaces;

    public interface IWorkerData
    {
        IList<IWorkForce> Workers { get; }
    }
}