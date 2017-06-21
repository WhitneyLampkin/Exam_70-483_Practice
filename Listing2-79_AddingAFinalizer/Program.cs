using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_79_AddingAFinalizer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class SomeType
    {
        ~SomeType()
        {
            // This code is called whent he finalize method executes.

            // Here, you can clean up other resources and maek sure that all memory is freed.
        }
    }
}
