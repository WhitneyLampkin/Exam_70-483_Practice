using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing1_73_CompilerGeneratedCodeForAForeachLoop
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

            List<Person>.Enumerator e = people.GetEnumerator();

            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                }
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if (d != null) d.Dispose();
            }
        }
    }
}
