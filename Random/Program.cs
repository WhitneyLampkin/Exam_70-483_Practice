using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    public static class Program
    {
        public static void Main()
        {
            int x = 42;
            float y = 54.456f;
            double d = 12345.1234;

            var z = Convert.ToInt32(y);
            var q = (int)y;

            Console.WriteLine(x.ToString());
            Console.WriteLine(z.ToString());
            Console.WriteLine(q.ToString());
            Console.WriteLine(d.ToString());

            Console.ReadLine();
        }
    }
}
