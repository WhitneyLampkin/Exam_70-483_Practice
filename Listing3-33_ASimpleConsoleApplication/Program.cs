using System;
using System.Threading;

namespace Listing3_33_ASimpleConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer(TimerCallback, null, 0, 2000);
            Console.ReadLine();
        }

        private static void TimerCallback(Object o)
        {
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
            GC.Collect();
        }
    }
}
