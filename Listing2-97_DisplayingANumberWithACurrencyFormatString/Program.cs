using System;
using System.Globalization;

namespace Listing2_97_DisplayingANumberWithACurrencyFormatString
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = 1234.56;

            Console.WriteLine(cost.ToString("C", new CultureInfo("en-Us"))); 

            // Displays $1234.56
        }
    }
}
