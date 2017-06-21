using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_73_ExecutingAMethodThroughReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo", new Type[] { typeof(int) });
            int result = (int)compareToMethod.Invoke(i, new object[] { 41 });
        }
    }
}
