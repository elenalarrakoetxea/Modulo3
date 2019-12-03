using System;

namespace TestUnitario
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleController mgr = new ConsoleController();
            Console.WriteLine(mgr.Salute());
        }
    }
}
