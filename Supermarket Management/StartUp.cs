using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Management
{
   public static class StartUp
    {
        public static void Main()
        {
            Engine engine = new Engine();
            engine.Run();
            Environment.Exit(0);
        }
    }
}
