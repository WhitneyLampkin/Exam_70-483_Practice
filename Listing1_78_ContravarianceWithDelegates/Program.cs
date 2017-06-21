using System.IO;

namespace Listing1_78_ContravarianceWithDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            ContravarianceDel del = DoSomething;
        }

        static void DoSomething(TextWriter tw) { }

        public delegate void ContravarianceDel(StreamWriter tw);
        
    }
}
