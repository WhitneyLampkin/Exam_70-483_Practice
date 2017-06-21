using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_33_UsingConcurrentQueues
{
    public static class Program
    {
        public static void Main()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);
            queue.Enqueue(21);
            queue.Enqueue(11);

            int result;
            if (queue.TryDequeue(out result))
                Console.WriteLine("Dequeue: {0}", result); //Result is always 42 becuase 1 one in is the last one out

            Console.ReadLine();
        }
    }
}
