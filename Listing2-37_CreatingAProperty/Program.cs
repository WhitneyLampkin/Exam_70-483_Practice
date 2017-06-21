using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_37_CreatingAProperty
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Person
        {
            private string _firstName;

            public string FirstName
            {
                get { return _firstName; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException();
                    _firstName = value;
                }
            }
        }
    }
}
