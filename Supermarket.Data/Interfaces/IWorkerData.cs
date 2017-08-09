using System.Collections.Generic;
using Supermarket.Models.Interfaces;

namespace Supermarket.Data
{
    public interface IWorkerData
    {
        IList<IWorkForce> Workers { get; }
    }
}