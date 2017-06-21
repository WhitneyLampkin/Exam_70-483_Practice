using System;

namespace Listing1_76_MulticastDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Multicast();

            Console.ReadLine();
        }

        public static void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public delegate void Del();

        public static void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;
            d();

            int invocationCount = d.GetInvocationList().GetLength(0);

            Console.WriteLine(invocationCount);
        }

        // Displays
        // MethodOne
        // MethodTwo
    }
}
