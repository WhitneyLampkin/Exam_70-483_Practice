using System;
using System.Text.RegularExpressions;

namespace Listing3_11_CollapseMultipleSpacesWithRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options);

            string input = "1 2 3 4  5";
            string result = regex.Replace(input, " ");

            Console.WriteLine(result); // Displays 1 2 3 4 5
        }
    }
}
