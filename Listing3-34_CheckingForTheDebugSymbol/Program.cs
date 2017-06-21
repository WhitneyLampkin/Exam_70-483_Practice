using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_34_CheckingForTheDebugSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void DebugDirective()
        {
            // This syntax is wrong and I'm not sure why.

            //#if DEBUG
            //Console.WriteLine("Debug mode");
            //#else
            //    Console.WriteLine("Not debug");
            //#endif
        }
    }
}
