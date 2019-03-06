using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public struct Card //a struct is very similar to a class. it cant be inherited
    {
        //public Card() //here we are setting default (constructor) values when an instance of card is created.
        //{             // so card will have these until we change them
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        public Suit Suit { get; set; } //this says the card class has a property of data type string 
                                         //called suit. You either get or set this property. by making 
                                        //it public, its accesable ot other parts of the program
        public Face Face { get; set; }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
