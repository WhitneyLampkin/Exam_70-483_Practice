using System;
using System.Text;

namespace Listing2_87_ChangingACharacterWithStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("A initial value");
            sb[0] = 'B';

            Console.WriteLine(sb);
        }
    }
}
