using System;

namespace Supermarket_Management
{
    public class StartUp
    {
        public static void Main()
        {
            Engine engine = new Engine();
            engine.Run();
            Environment.Exit(0);
        }
    }
}
