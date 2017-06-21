using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_23_ExplicitlyCastingATypeToADerivedType
{
    class Program
    {
        static void Main(string[] args)
        {
            Object stream = new MemoryStream();
            MemoryStream memoryStream = (MemoryStream)stream;
        }
    }
}
