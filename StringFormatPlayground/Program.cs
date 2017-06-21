using System;

namespace StringFormatPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FormatCoins("Whitney", 23));
        }
        public static string FormatCoins(string name, int coins)
        {
            return string.Format("Player {0} collected {1} coins.", name, coins.ToString("###0"));
        }
    }
}
