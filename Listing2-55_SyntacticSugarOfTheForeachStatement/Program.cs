using System;
using System.Collections.Generic;

namespace Listing2_55_SyntacticSugarOfTheForeachStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 9 };

            using (List<int>.Enumerator enumerator = numbers.GetEnumerator())
            {
                while (enumerator.MoveNext()) Console.WriteLine(enumerator.Current);
            }
        }
    }
}
