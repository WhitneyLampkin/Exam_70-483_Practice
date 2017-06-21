using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_29_CreatingACustomDynamicObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
        public class SampleObject : DynamicObject
        {
            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                result = binder.Name;
                return true;
            }
        }

    }
}
