using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_61_ComplexIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        
        void Check(char input)
        {
            if (input == 'a'
                || input == 'e'
                || input == 'i'
                || input == 'o'
                || input == 'u')
            {
                Console.WriteLine("Input is a vowel");
            }
            else
            {
                Console.WriteLine("Input is a consonant");
            }
        }
    }
}
