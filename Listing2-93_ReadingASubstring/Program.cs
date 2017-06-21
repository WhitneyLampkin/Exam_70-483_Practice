using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_93_ReadingASubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Sample Value";

            // The first argument of Substring tells where to start
            //The 2nd argument tells how many characters to include
            string subString = value.Substring(3, 6); // Returns 'Sample'
        }
    }
}
