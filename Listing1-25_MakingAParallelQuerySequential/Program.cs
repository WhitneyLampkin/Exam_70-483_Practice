using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_25_MakingAParallelQuerySequential
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered()   //The queried is still processed in parallel but the query is sorted
                .Where(i => i % 2 == 0).AsSequential();

            foreach (var item in parallelResult.Take(5))
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
