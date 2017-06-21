using System;

namespace Listing2_86_CreatingALargeNumberOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = string.Empty;

            // This code will run 10000 and each time, a new string is created (strings are immutable).
            // Immediately after each run, the old string will be ready for GC.

            for (int i = 0; i < 10000; i++)
            {
                s += "x";

                Console.WriteLine(s);
                
            }
        }
    }
}
