using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Models.Interfaces
{
    public interface IRandomNumberGenerator
    {
        int rnd(int start, int end);
    }
}
