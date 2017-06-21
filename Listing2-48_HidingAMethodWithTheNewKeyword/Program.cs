using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_48_HidingAMethodWithTheNewKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.Execute();
            b = new Derived();
            b.Execute();
        }
    }
    class Base
    {
        public void Execute()
        {
            Console.WriteLine("Base.Execute");
        }
    }

    class Derived : Base
    {
        public new void Execute()
        {
            Console.WriteLine("Derived.Execute");
        }
    }
}
