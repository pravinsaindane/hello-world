using System;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
#if DebugConfig
        Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION");
#endif
            Console.WriteLine("Hello, world!");
        }
    }
}
