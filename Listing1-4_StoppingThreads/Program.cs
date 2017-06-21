using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1_4_StoppingThreads
{
    public static class Program
    {
        public static void Main()
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(() =>                 //This lambda expression is a shorthand for a delegate??? (pg7)
            {
                while (!stopped)                                        //Ensures the thread keeps running until stop is true.
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            stopped = true;                                             //Ends the thread.
            t.Join();                                                   //Causes console app to wait until the thread finishes executing.
        }
    }
}
