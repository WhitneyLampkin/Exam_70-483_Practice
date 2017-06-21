using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_58_NullCoalescingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int y = x ?? -1;
        }
    }
}
