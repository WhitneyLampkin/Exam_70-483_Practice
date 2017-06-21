using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_26_UsingTheBuilt_InCovertAndParseMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32("42");
            value = int.Parse("42");
            bool success = int.TryParse("42", out value);
        }
    }
}
