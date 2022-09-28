using System;
using System.Threading;

namespace CSharpConcurrencyRecipes
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY); // kick off a new thread
            t.Start(); // running WriteY()

            // simultaneously do something on the main thread.
            for (int i = 0; i < 1000; i++) Console.Write("x");
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}
