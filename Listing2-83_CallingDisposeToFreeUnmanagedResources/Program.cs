using System.IO;

namespace Listing2_83_CallingDisposeToFreeUnmanagedResources
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            stream.Dispose();
            File.Delete("temp.dat");

            // The above should be replaced with the using statement as so:
            // using (StreamWriter sw = File.CreateText("temp.dat")) { }
        }
    }
}
