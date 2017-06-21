using System;
using System.IO;

namespace Listing2_81_ForcingAGarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            GC.Collect();
            GC.WaitForPendingFinalizers(); // Makes sure that all finalizers run before the code continues.
            File.Delete("temp.dat");
        }
    }
}
