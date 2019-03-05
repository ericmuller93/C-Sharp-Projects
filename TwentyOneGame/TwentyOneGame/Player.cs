using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player) //overloaded operator example
        {                                                       // an example of its use is commented out in Prgram.cs
            game.Players.Add(player);
            return game;
        }

        public static Game operator- (Game game, Player player) //overloaded operator example
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
