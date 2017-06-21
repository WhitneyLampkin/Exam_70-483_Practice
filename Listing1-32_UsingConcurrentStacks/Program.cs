using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_32_UsingConcurrentStacks
{
    public static class Program
    {
        public static void Main()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(42);

            int result;
            if (stack.TryPop(out result))
                Console.WriteLine("Popped: {0}", result);

            stack.PushRange(new int[] { 1, 2, 3 });

            int[] values = new int[2];
            stack.TryPopRange(values);

            foreach (var i in values)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
