using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_14_UsingAWhereClauseOnAClassDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MyClass<T> where T : class, new()
    {
        public MyClass()
        {
            MyProperty = new T();
        }

        T MyProperty { get; set; }
    }
}
