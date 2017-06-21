using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_62_GettingASpecificAttributeInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            // The conditional class is within its own file 

            ConditionalAttribute conditionalAttribute =
                (ConditionalAttribute)Attribute.GetCustomAttributes(
                typeof(ConditionalClass),
                typeof(ConditionalAttribute)).First();
        }
    }
}
