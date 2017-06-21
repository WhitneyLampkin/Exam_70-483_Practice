using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1_17_UsingParallelBreak
{
    public static class Program
    {
        public static void Main()
        {
            ParallelLoopResult result = Parallel.
                For(0, 1000, (int i, ParallelLoopState loopState) =>
                {
                    if (i == 500)
                    {
                        Console.WriteLine("Breaking loop");
                        loopState.Break();
                    }
                    
                    return;
                });

            Console.WriteLine(result.IsCompleted);
            Console.WriteLine(result.LowestBreakIteration);

            Console.ReadLine();
        }
    }
}
