using System;
using System.Globalization;

namespace Listing3_6_UsingConfigurationOptionsWhenParsingANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo english = new CultureInfo("En");
            CultureInfo dutch = new CultureInfo("Nl");

            string value = "€19.95";
            decimal d = decimal.Parse(value, NumberStyles.Currency, dutch);
            Console.WriteLine(d.ToString(english));

            // Displays 1995 and should be 19.95 ... hmmm...
        }
    }
}
