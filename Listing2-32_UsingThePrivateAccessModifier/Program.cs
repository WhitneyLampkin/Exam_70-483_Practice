using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_32_UsingThePrivateAccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private string _myField;

        public string MyProperty
        {
            get { return _myField; }
            set { _myField = value; }
        }

    }
}
