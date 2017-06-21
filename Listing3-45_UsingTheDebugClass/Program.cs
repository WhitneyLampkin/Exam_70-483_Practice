using System.Diagnostics;

namespace Listing3_45_UsingTheDebugClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Starting application");
            Debug.Indent();
            int i = 1 + 2;
            Debug.Assert(i == 3);
            Debug.WriteLineIf(i > 0, "i is greater than 0");
        }
    }
}
