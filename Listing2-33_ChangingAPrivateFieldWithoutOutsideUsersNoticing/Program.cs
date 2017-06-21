using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_33_ChangingAPrivateFieldWithoutOutsideUsersNoticing
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Accessibility
        {
            // Initialization code and error checking omitted

            // The implementation has changed to lookup the value of MyProperty but outside users aren't aware...
            private string[] _myField;

            public string MyProperty
            {
                get { return _myField[0]; }
                set { _myField[0] = value; }
            }

        }
    }
}
