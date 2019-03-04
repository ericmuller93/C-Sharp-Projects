using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public abstract class Game //this is an abstract class. Meaning you cant instantiate "Game". You only will
    {                          //create A game like TwentyOne or Poker.
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //this is an abtract method. Any class inheriting this class MUST
                                     //implement this method. 

        public virtual void ListPlayers() //this method is "virtual". This method gets inherited but will have
        {                                 // the ability to be overrriden so you can customize it 
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
