using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_69_ImplementingForLoopWithWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };

            int index = 0;
            while(index < values.Length)
            {
                Console.WriteLine(values[index]);
                index++;
            }
        }
    }
}
