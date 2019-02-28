using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Card
    {
        public Card() //here we are setting default values when an instance of card is created.
        {             // so card will have these until we change them
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; } //this says the card class has a property of data type string 
                                         //called suit. You either get or set this property. by making 
                                        //it public, its accesable ot other parts of the program
        public string Face { get; set; }
    }
}
