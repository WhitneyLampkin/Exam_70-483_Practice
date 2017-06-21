using System;

namespace Listing2_58_ApplyingAnAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // The class is called SerializableAttribute, but the Attribute can be left off when using it.
    // Types can have as many attributes as necessary and some can be used multiple times.

    [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
