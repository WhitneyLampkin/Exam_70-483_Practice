using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_77_CovarianceWithDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            CovarianceDel del;

            del = MethodStream;
            del = MethodString;
        }

        public delegate TextWriter CovarianceDel();

        public static StreamWriter MethodStream() { return null; }
        public static StringWriter MethodString() { return null; }
    }
}
