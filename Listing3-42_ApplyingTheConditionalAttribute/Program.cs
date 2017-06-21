using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_42_ApplyingTheConditionalAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [Conditional("DEBUG")]
        public static void Log(string message)
        {
            Console.WriteLine("message");
        }
    }
}
