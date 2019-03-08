﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Player
    {
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if(Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
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
