using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_41_CallAMethodOnlyInDebugBuild
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void SomeMethod()
        {
            /*
                #if DEBUG
                Log("Step1");
                #endif 
            */
        }

        private static void Log(string message)
        {
            Console.WriteLine("message");
        }
    }
}
