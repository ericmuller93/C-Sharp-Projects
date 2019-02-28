using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); //creating a new deck item named deck
            deck = Shuffle(deck); //here we are reassigning deck to what deck becomes when shuffle method is applied

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

            //  THIS IS THE MANUAL WAY THAT I CREATED A CARD IN A DECK WITHOUT THE DECK HAVING THE 
            // CONSTRUCTOR. I WANTED TO KEEP THIS HERE FOR REFERENCE. 

            //Card cardOne = new Card(); //creating a new card, itll be defaulted to 2 of spades
            //cardOne.Face = "Queen";   //but here we are changing that default value
            //cardOne.Suit = "Spades";

            //Deck deck = new Deck(); //creating a new deck item named deck
            //deck.Cards = new List<Card>(); //and now we are using the property cards of deck. Were creating that list for it

            //deck.Cards.Add(cardOne); //now were adding cardOne to that list

            //Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
