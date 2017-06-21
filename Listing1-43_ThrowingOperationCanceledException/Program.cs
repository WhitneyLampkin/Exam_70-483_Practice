using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1_43_ThrowingOperationCanceledException
{
    class Program
    {
        static void Main(string[] args)
        {
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

                token.ThrowIfCancellationRequested(); //Adding to Listing 1-42

            }, token);

            try
            {
                Console.WriteLine("Press enter to stop the task.");
                Console.ReadLine();

                cancellationTokenSource.Cancel();
                task.Wait();
            }
            catch(AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions[0].Message);
            }
            
            Console.WriteLine("Press enter to end the application.");
            Console.ReadLine();
        }
    }
}
