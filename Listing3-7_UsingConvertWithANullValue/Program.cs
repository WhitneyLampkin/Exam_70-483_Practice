using System;

namespace Listing3_7_UsingConvertWithANullValue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert is used to convert between base types
            // Convert allows null values and Parse doesn't!!!!!!!!!!!!!

            int i = Convert.ToInt32(null);
            Console.WriteLine(i);
        }
    }
}
