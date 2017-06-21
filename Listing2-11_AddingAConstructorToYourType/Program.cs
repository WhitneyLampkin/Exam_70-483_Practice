using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_11_AddingAConstructorToYourType
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(52);
        }
    }

    class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }
    }

    class Deck
    {
        private int _maximumNumberOfCards;

        public List<Card> Cards { get; set; }

        //Below is the constructor which takes an argument of int
        public Deck(int maximumNumberOfCards)
        {
            this._maximumNumberOfCards = maximumNumberOfCards;
            Cards = new List<Card>();
        }

        // Rest of Class
    }
}
