using System;
using System.Threading;

namespace Listing1_2_BackgroundThreads
{
    public static class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;                                  //Program exits immediately.
            //t.IsBackground = false;                               //Program prints ThreadProc message 10 times.
            t.Start();

            //Console.ReadLine();
        }
    }
}
