using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_92_UsingStartsWithAndEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "<mycustomerinput>";
            if (value.StartsWith("<")) { }
            if (value.EndsWith(">")) { }
        }
    }
}
