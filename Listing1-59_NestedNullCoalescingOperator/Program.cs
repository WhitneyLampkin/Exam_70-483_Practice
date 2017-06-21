using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_59_NestedNullCoalescingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int? z = null;
            int y = x ??
                    z ??
                    -1;

            //Can do the same with an if statement but this is shorter and more readable
        }
    }
}
