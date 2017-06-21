using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_39_ImplementingAnInterfaceExplicitly
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        interface IInterfaceA
        {
            void MyMethod();
        }

        class Implementation : IInterfaceA
        {
            // Using the interface's name makes this an explicit implementation!

            void IInterfaceA.MyMethod() { }
        }
    }
}
