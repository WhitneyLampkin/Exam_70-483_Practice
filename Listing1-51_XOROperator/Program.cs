using System;

namespace Listing1_51_XOROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a ^ a); //False
            Console.WriteLine(a ^ b ^ b ^ b); //True
            Console.WriteLine(b ^ b); //False

            Console.ReadLine();
        }
    }
}
