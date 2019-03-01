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
            deck.Shuffle(); //here we are reassigning deck to what deck becomes when shuffle method is applied. For why an int is here check out line 53.

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
            //  THIS IS THE MANUAL WAY THAT I CREATED A CARD IN A DECK WITHOUT THE DECK HAVING THE 
            // CONSTRUCTOR. I WANTED TO KEEP THIS HERE FOR REFERENCE. 

            //Card cardOne = new Card(); //creating a new card, itll be defaulted to 2 of spades
            //cardOne.Face = "Queen";   //but here we are changing that default value
            //cardOne.Suit = "Spades";

            //Deck deck = new Deck(); //creating a new deck item named deck
            //deck.Cards = new List<Card>(); //and now we are using the property cards of deck. Were creating that list for it

            //deck.Cards.Add(cardOne); //now were adding cardOne to that list

            //Console.ReadLine();
        

        // this is our shuffle function I pasted into deck then edited. I could just keep this here and call it 
        // but we want it as a method of deck.

        //public static Deck shuffle(Deck deck, out int timesshuffled, int times = 1)
        //{   
        //    timesshuffled = 0;
        //    for (int i = 0; i < times; i++)             
        //    {
        //          timesshuffled++;
        //          List<Card> templist = new List<Card>();
        //          Random random = new Random();
        
        //         while (deck.Cards.Count > 0)
        //          {
        //            int randomindex = random.Next(0, deck.Cards.Count);
        //            templist.Add(deck.Cards[randomindex]);
        //           deck.Cards.RemoveAt(randomindex);
        //         }
        //         deck.Cards = templist;
                 
        //    }
        //    return deck;
        //}


        //public static Deck Shuffle(Deck deck) //we can just put (int times = 1) as a parameter creating a default value 
        //{                                     //making the int parameter optionl. Its always 1 unless I put something else. It would look like this public static Deck Shuffle(Deck deck, int times=1)
        //    List<Card> TempList = new List<Card>();
        //    Random random = new Random();

        //    while (deck.Cards.Count > 0)
        //    {
        //        int randomIndex = random.Next(0, deck.Cards.Count);
        //        TempList.Add(deck.Cards[randomIndex]);
        //        deck.Cards.RemoveAt(randomIndex);
        //    }
        //    deck.Cards = TempList;
        //    return deck;
        //}

        ////below method is Shuffle, but multiple times according to what you input
        //public static Deck Shuffle(Deck deck, int times) //this is an overloaded method. Notice it has the same name Shuffle
        //{                                               //but this one takes 2 parameters as opposed to 1, so C# knows they are
        //    for (int i = 0; i < times; i++)             //depending on the amount of parameters given when its called. 
        //    {                                           //Intellisense will recognize this too when youre calling Shuffle
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

        //below is the function with all fancy things included. Including an "Out method". We define an out 
        // int "timesShuffled" which we have it ++ whenever the deck is shuffled. We also need to add this 
        // "out timesShuffled" to line 14s parameters nad declare it somehwere as timesShuffled = 0; (line 13 would be good)

        //public static deck shuffle(deck deck, out int timesShuffled, int times = 1) 
        //{   
        //    timesShuffled = 0;
        //    for (int i = 0; i < times; i++)             
        //    {
        //          timesShuffled++;
        //          list<card> templist = new list<card>();
        //          random random = new random();
        //
        //          while (deck.cards.count > 0)
        //          {
        //            int randomindex = random.next(0, deck.cards.count);
        //            templist.add(deck.cards[randomindex]);
        //            deck.cards.removeat(randomindex);
        //          }
        //          deck.cards = templist;
        //          
        //    }
        //    deck = shuffle(deck);
        //    return deck;
        //}
    }
}
