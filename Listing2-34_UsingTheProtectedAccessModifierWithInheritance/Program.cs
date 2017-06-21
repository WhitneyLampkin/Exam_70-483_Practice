﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_34_UsingTheProtectedAccessModifierWithInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Base
        {
            private int _privateField = 42;
            protected int _protectedField = 42;

            private void MyPrivateMethod() { }
            protected void MyProtectedMEthod() { }
        }

        public class Derived : Base
        {
            public void MyDerivedMethod()
            {
                // _privateField = 41; // Not OK, this will generate a compile error
                _protectedField = 43; //OK, protected methods can be accessed
            }
        }
    }
}
