using System;
using System.Diagnostics;

namespace ExamineRunningProcesses
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalProcesses = 0;
            int totalThreads = 0;

            foreach (var p in Process.GetProcesses())
            {
                Console.WriteLine(p.ProcessName);
                Console.WriteLine("     PID: " + p.Id);
                Console.WriteLine("     Memory: " + p.PeakWorkingSet64);
                Console.WriteLine("     Threads: " + p.Threads.Count);

                totalProcesses++;
                totalThreads += p.Threads.Count;
            }

            Console.WriteLine();
            Console.WriteLine("Number of Processes: " + totalProcesses);
            Console.WriteLine("Number of Threads: " + totalThreads);

            Console.ReadLine();
        }
    }
}
