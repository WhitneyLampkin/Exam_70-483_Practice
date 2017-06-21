using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_07_UsingNamedAndOptionalArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod(1, thirdArg: true);
        }

        static void MyMethod(int firstArg, string secondArg = "default value", bool thirdArg = false) { }
    }
    
}
