using System;

namespace Listing2_91_UsingIndexOfAndLastIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Sample Value";

            // The line below returns the index of the first occurence.
            int indexOfp = value.IndexOf('p'); //returns 6

            // The line below returns the last occurence.
            int lastIndexOfm = value.LastIndexOf('m'); //returns 5

            Console.WriteLine(indexOfp);
            Console.WriteLine(lastIndexOfm);
        }
    }
}
