using System;

namespace Listing1_75_UsingADelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            // A delegate is a type that defines a method signature.
            // You can instantiate a delegate and let itpoint to another method.
            // You can invoke a method through a delegate.

            UseDelegate();
        }

        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y) { return x + y; }
        public static int Multiply(int x, int y) { return x * y; }

        public static void UseDelegate()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3,4));  //Displays 7

            calc = Multiply;
            Console.WriteLine(calc(3,4)); //Displays 12
        }
    }
}
