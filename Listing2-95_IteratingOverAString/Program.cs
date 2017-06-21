using System;

namespace Listing2_95_IteratingOverAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Custom Value";
            foreach (char c in value)
            {
                Console.WriteLine(c);
            }
        }
    }
}
