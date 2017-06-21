using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_60_ConditionalOperator
{
    class Program
    {
        //Conditional operator (?:)

        static void Main(string Args)
        {
            GetValue(true);
        }
        private static int GetValue(bool p)
        {
            //if (p)
            //    return 1;
            //else
            //    return 0;

            return p ? 1 : 0; //This replaces the above if/else statement
        }
    }
}
