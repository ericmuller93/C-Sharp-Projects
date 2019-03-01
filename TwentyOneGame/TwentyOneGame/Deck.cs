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
        public List<Card> Cards { get; set; } //this is the property

        //now we want this below method (shuffle) to act on the object its attached to
        // we had to slightly modify the method because its a part of this class now, we dont
        // have to pass Cards.Deck all around 
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> templist = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomindex = random.Next(0, Cards.Count);
                    templist.Add(Cards[randomindex]);
                    Cards.RemoveAt(randomindex);
                }
                Cards = templist;
            }
        }
    }
}
