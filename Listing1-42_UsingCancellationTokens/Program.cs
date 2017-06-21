using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1_42_UsingCancellationTokens
{
    class Program
    {
        static void Main(string[] args)
        {
            //The 'CancellationToken' class allows us to cancel long-running tasks.
            //A 'CancellationToken' is passed to a Task, which periodically monitors the token 
            //to see if cancellation is requested.

            CancellationTokenSource cancellationTokenSource =
                new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
            }, token);

            Console.WriteLine("Press enter to stop the task.");
            Console.ReadLine();
            cancellationTokenSource.CancelAfter(5000);

            Console.WriteLine("Press enter to end the application.");
            Console.ReadLine();
        }
    }
}
