using System;
using System.Threading.Tasks;

namespace Listing1_10_AddingContinuations
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine(t.Result);
            Console.ReadLine();
        }
    }
}
