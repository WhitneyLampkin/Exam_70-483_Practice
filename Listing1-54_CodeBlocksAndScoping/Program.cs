using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_54_CodeBlocksAndScoping
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            if (b)
            {
                int r = 42;
                b = false;

                //r is not accessible
                //b is now false
            }
        }
    }
}
