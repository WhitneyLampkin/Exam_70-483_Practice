﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_61_SeeingWhetherAnAttributeIsDefined
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Attribute.IsDefined(typeof(Person), typeof(SerializableAttribute)))
            {

            }
        }
    }

    [Serializable]
    class Person { }
}
