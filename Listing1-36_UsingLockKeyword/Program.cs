using System;
using System.Threading.Tasks;

namespace Listing1_36_UsingLockKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            object _lock = new object();

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    lock (_lock) n++;
            });

            for (int i = 0; i < 1000000; i++)
                lock (_lock) n--;

            up.Wait();
            Console.WriteLine(n);
            Console.ReadLine();

            //Now the result is predictable and "0"
            //Only 1 loop can modify the variable n at a time
        }
    }
}
