using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_59_UsingMultipleAttributes
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        // The Conditional attributes below tell the compiler to only run the method a specific compiler option is specified.

        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        static void MyMethod()
        {
            //Some method implementation
        }
    }
    
}
