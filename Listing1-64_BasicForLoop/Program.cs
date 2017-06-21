using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_64_BasicForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }

            //Displays
            //123456
        }
    }
}
