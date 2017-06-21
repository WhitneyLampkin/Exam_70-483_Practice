using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_19_BoxingAnIntergerValue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing- takes a value off the stack and puts it inside of a new object on the heap; a reference to the object on the heap is stored on the stack
            // Unboxing- takes a reference type off the heap and stores a value type on the stack that contains the value from the heap.

            int i = 42;         //int is a value type
            object o = i;       //object is a reference type
            int x = (int)o;     //casting o back to an int 
        }
    }
}
