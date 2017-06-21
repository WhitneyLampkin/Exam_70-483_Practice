using System;

namespace MulticastDelegateExample
{
    public delegate void ProgressReporter(int percentComplete);

    public class Util
    {
        public static void HardWork(ProgressReporter p)
        {
            for (int i = 1; i < 11; i++)
            {
                p(i * 10);
                //System.Threading.Thread.Sleep(1);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Util.HardWork(p);

            Console.ReadLine();
        }
        static void WriteProgressToConsole(int percentComplete)
        {
            Console.WriteLine(percentComplete);
        }

        static void WriteProgressToFile(int percentComplete)
        {
            Console.WriteLine(percentComplete);
        }
    }
}
