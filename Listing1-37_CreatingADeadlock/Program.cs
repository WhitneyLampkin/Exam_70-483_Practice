using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1_37_CreatingADeadlock
{
    class Program
    {
        static void Main(string[] args)
        {
            object lockA = new object();
            object lockB = new object();

            var up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Thread.Sleep(5000);
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB)
            {
                Thread.Sleep(1000);
                lock (lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }

            up.Wait();
            Console.ReadLine(); 
        }
    }
}
