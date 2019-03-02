using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class TwentyOneGame : Game, IWalkAway //to inherit from a class all you need is that colon and the class name
    {
        public override void Play() //use the override keyword which says we will use this abstract method that
        {                           //was inherited from the parent class Game
            throw new NotImplementedException();
        }

        public override void ListPlayers() //this is a virtual method. We customized what the parent class 
        {                                  //gave us so we can do what we want, like add the phrase 21 Players
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
