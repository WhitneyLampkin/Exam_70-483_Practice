using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_80_CreatingALambdaExpressionWithMultipleStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc =
            (x, y) =>
            {
                Console.WriteLine("Addingnumbers");
                return x + y;
            };

            int result = calc(3, 4);
            // Displays
            // Adding numbers
        }

        public delegate int Calculate(int x, int y);
    }
}
