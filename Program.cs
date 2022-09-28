using System;
using System.Threading;

namespace CSharpConcurrencyRecipes
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
        }

        static void Go()
        {
            for (int cycles = 0; cycles < 5; cycles++) Console.Write("?");
        }
    }
}
