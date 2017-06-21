using System;
using System.Threading;

namespace Listing1_5_ThreadStaticAttributes
{
    public static class Program
    {
        //Without the ThreadStatic Attribute, the maximum value of of _field in 20 and both threads access the same value.
        //With the ThreadStatic Attiribute, the maximum value of _field is 10 and each thread has access to it's own _field value.
        [ThreadStatic]
        public static int _field;

        public static void Main()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey(); ;
        }
    }
}
