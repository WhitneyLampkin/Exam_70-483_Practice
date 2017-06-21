using System;
using System.Text.RegularExpressions;

namespace Listing3_10_ValidateAZipCodeWithARegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = ValidateZipCodeRegEx("3425BC");

            Console.WriteLine(result);
        }

        static bool ValidateZipCodeRegEx(string zipCode)
        {
            Match match = Regex.Match(zipCode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}
