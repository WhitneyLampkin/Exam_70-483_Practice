using System;

namespace Listing1_79_LambdaExpressionToCreateDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4)); // Displays 7

            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }

        public delegate int Calculate(int x, int y);
    }
}
