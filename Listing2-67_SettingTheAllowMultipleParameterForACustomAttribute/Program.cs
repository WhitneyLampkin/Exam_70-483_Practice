using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_67_SettingTheAllowMultipleParameterForACustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [Attributeusage(AttributeTargets.Class, AllowMultiple = true)]
        class MyMultipleUsageAttribute : Attribute { }
    }
}
