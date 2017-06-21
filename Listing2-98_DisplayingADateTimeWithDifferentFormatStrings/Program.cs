using System;
using System.Globalization;

namespace Listing2_98_DisplayingADateTimeWithDifferentFormatStrings
{
    class Program
    {

        static void Main(string[] args)
        {
            DateTime d = new DateTime(2017, 6, 19);
            CultureInfo provider = new CultureInfo("en-US");

            Console.WriteLine(d.ToString("d", provider)); // Displays 6/19/2017 
            Console.WriteLine(d.ToString("D", provider)); // Displays Monday June 19, 2017
            Console.WriteLine(d.ToString("M", provider)); // Displays June 19
        }
    }
}
