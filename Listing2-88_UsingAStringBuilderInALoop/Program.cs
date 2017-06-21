using System;
using System.Text;

namespace Listing2_88_UsingAStringBuilderInALoop
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            for (int i = 0; i < 10000; i++)
            {
                sb.Append("x");

                Console.WriteLine(sb);
            }
        }
    }
}
