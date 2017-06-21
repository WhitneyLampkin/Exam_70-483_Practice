using System.Diagnostics;

namespace Listing3_43_ApplyingTheDebuggerDisplayAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [DebuggerDisplay("Name = {FirstName} {LastName}")]
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
