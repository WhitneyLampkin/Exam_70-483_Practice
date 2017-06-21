using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_66_ForLoopWithACustomIncrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index += 2)
            {
                Console.WriteLine(values[index]);
            }

            //Displays
            //135
        }
    }
}
