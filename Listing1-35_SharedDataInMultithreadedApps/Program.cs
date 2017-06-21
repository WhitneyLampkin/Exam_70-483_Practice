using System;
using System.Threading.Tasks;

namespace Listing1_35_SharedDataInMultithreadedApps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    n++;
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                n--;
            }

            up.Wait();
            Console.WriteLine(n);
            Console.ReadLine();

            //Each time the program runs, we get different numbers
            //The data is unpredictable because both loops are acting on "n" at the same time
        }
    }
}
