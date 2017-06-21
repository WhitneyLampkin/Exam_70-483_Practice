using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_71_ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };

            foreach (int i in values)
            {
                Console.Write(i);
            }
        }
    }
}
