using System.Collections.Generic;

namespace Listing1_72_ChangingItemsInAForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        void CannotChangeForeachIterationVariable()
        {
            var people = new List<Person>
        {
            new Person() { FirstName = "Whitney", LastName = "Lampkin" },
            new Person() { FirstName = "Nicole", LastName = "Sutton" },
        };

            foreach (var p in people)
            {
                p.LastName = "Changed"; //This is allowed
                                        // p = new Person(); //This gives a compiler error
            }
        }
    }
}
