using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_4_UsingParse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parse and TryParse are used when converting a string to a different data type.

            string value = "true";
            bool b = bool.Parse(value);
            Console.WriteLine(b);
        }
    }
}
