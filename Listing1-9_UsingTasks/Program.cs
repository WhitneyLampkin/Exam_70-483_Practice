using System;
using System.Threading.Tasks;

namespace Listing1_9_UsingTasks
{
    public static class Program
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            Console.WriteLine(t.Result);
            Console.ReadLine();
        }
    }
}
