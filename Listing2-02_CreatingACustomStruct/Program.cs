using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_02_CreatingACustomStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public struct Point
    {
        public int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
}
