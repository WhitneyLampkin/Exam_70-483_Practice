using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_12_ChainingConstructors
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class ConstructorChaining
    {
        private int _p;

        public ConstructorChaining() : this(3) { }
        public ConstructorChaining(int p)
        {
            this._p = p;
        }
    }
}
