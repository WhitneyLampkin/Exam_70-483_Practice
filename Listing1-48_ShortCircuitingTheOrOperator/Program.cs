using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_48_ShortCircuitingTheOrOperator
{
    class Program
    {
        public void Main(string[] args)
        {
            bool x = true;
            bool result = x || GetY();
        }

        private bool GetY()
        {
            Console.WriteLine("This method doesn't get called.");
            return true;
        }
    }
}
