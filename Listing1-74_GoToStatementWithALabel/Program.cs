using System;

namespace Listing1_74_GoToStatementWithALabel
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            if (x == 3) goto customLabel;
            x++;

            customLabel:
            Console.WriteLine(x);
            Console.ReadLine();

            //Displays 3
        }
    }
}
