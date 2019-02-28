using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Deck
    {
        public Deck() //this is the deck constructor. Constructors always go at the top. When a deck is created this all will be defaulted
        {
            Cards = new List<Card>(); //creates a list of cards that starts empty
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //gives us a list of our 4 possible suits
            List<string> Faces = new List<string>() //gives us a list of the 13 possible faces
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            foreach (string face in Faces) //nested for loop. We will so this so every face gets matched
            {                             // up with every suit and added to our cards in the deck
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
