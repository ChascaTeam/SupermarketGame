using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Data.Interfaces
{
    public interface IWorkerData
    {
        IList<IWorkForce> Workers { get; }
    }
}