using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game //this is an abstract class. Meaning you cant instantiate "Game". You only will
    {                          //create A game like TwentyOne or Poker.
        private List<Player> _players = new List<Player>(); //creating an empty list of players. need this because you can just add something to a null list
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>(); //same as above but for list
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

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
