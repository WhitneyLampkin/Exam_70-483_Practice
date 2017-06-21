using System.Collections.Generic;
using System.Linq;

namespace Listing2_10_CreatingACollectionSuchAsADeckClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 1, 3, 5 };
            myList[0] = 1;
        }
    }

    class Card { }

    class Deck
    {
        public ICollection<Card> Cards { get; private set; }

        public Card this[int index]
        {
            get { return Cards.ElementAt(index); }
        }
    }

    class MyClass
    {
        // This field is static and doesn't need to be accessed by an instance of 'MyClass'
        // It can be directly called with MyClass.MyStaticField 
        // and is shared with all code that has access to it.

        public static int MyStaticField = 42;
    }
}
