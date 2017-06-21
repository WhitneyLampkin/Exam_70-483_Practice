using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_36_EncapsulatingAFieldWithCustomMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        // The below line of code represents a field
        private int _field;

        // The properties below look like regular fields, but that include accessors 
        // that get and set values
        public void SetValue(int value) { _field = value; }
        public int GetValue() { return _field; }
    }
}
