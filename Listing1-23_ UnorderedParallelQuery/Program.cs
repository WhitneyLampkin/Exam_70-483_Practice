using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_23__UnorderedParallelQuery
{
    class Program
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var item in parallelResult)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
