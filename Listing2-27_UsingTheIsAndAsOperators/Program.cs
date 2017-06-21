using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_27_UsingTheIsAndAsOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // The as and is operators checks to see if type conversion can be done safely

            

        }

        void OpenConnection(DbConnection connection)
        {
            if(connection is SqlConnection)
            {
                // Run some special code!
            }
        }

        void LogStream(Stream stream)
        {
            // At this point we don't know what derived type of the base class Stream will be passed in.
            // If it's a MemoryStream, we want to do something special here...

            MemoryStream memoryStream = stream as MemoryStream;
            if(memoryStream != null)
            {
                // Write some fancy code here!
            }
        }
    }
}
