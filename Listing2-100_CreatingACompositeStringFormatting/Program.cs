using System;

namespace Listing2_100_CreatingACompositeStringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            string result = string.Format("a: {0}, b: {1}", a, b);
            Console.WriteLine(result); // Displays 'a: 2, b: 2'
        }
    }
}
