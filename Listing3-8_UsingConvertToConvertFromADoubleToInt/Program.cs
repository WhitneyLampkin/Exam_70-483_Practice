using System;

namespace Listing3_8_UsingConvertToConvertFromADoubleToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 23.15;
            int i = Convert.ToInt32(d);
            Console.WriteLine(i);
        }
    }
}
