using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_50_ShortCircuitingTheAndOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Process("Test");
        }

        public static void Process(string input)
        {
            bool result = (input != null) && (input.StartsWith("v"));
        }
    }
}
