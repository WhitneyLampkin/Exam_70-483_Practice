using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_68_AddingPropertiesToACustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    class CompleteCustomAttribute : Attribute
    {
        public CompleteCustomAttribute(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}
