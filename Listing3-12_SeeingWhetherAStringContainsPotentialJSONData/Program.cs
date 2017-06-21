using System;

namespace Listing3_12_SeeingWhetherAStringContainsPotentialJSONData
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notJson = IsJson("{asdf");
            bool isJson = IsJson("[]");

            Console.WriteLine(notJson);     // Returns False
            Console.WriteLine(isJson);      // Returns True
        }

        public static bool IsJson(string input)
        {
            input = input.Trim();
            return input.StartsWith("{") && input.EndsWith("}") || input.StartsWith("[") && input.EndsWith("]");
        }
    }
}
