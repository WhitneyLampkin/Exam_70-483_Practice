using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_5_UsingTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "1";
            int result;
            bool success = int.TryParse(value, out result);

            if (success)
            {
                // value is a valid integer, result contains the value
            }
            else
            {
                // value is not a valid integer
            }
        }
    }
}
