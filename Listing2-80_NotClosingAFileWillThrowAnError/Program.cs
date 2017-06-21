using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_80_NotClosingAFileWillThrowAnError
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");

            File.Delete("temp.dat"); // An exception is thrown here because the file is already open. 
        }
    }
}
