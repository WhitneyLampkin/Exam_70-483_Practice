using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_63_GoToSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("Case 1");
                        goto case 2;
                    }
                case 2:
                    {
                        Console.WriteLine("Case 2");
                        break;
                    }
            }

            //Displays Case 1
            //Displays Case 2
        }
    }
}
