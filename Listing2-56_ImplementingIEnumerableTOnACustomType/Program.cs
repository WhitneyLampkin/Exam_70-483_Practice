using System.Collections;
using System.Collections.Generic;

namespace Listing2_56_ImplementingIEnumerableTOnACustomType
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class People : IEnumerable<Person>
    {
        public People(Person[] people)
        {
            this.people = people;
        }

        Person[] people;

        public IEnumerator<Person> GetEnumerator()
        {
            for (int index = 0; index < people.Length; index++)
            {
                // Yield is a special keyword that can only be used in the context of iterators.
                // It tells the compiler to turn regular code into a state machine. 
                // The generated code keep track of where you are in teh collection and implements
                // the MoveNext and Current methods.

                yield return people[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
