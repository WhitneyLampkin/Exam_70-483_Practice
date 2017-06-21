using System;
using System.Text.RegularExpressions;

namespace Listing2_94_ChangingAStringWithARegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(Mr\\.? |Mrs\\.? |Ms\\.? )";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" };

            foreach (string name in names)
            {
                Console.WriteLine(Regex.Replace(name, pattern, string.Empty));
            }
        }
    }
}
