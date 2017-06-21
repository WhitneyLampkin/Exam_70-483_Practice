using System;
using System.Threading;

namespace Listing1_1_CreatingThreads
{
    public static class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(8);                                        //Had to increase Thread.Sleep(0) to get the desired output.
            }
        }

        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(8);                                        //Had to increase Thread.Sleep(0) to get the desired output.
            }
            t.Join();
            Console.ReadLine();

        }
    }
}
