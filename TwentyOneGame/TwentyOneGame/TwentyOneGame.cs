using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class TwentyOneGame : Game, IWalkAway //to inherit from a class all you need is that colon and the class name
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play() //use the override keyword which says we will use this abstract method that
        {                           //was inherited from the parent class Game
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); //here we refreshed everyones hands
            Console.WriteLine("Please Your Bet!");

            foreach (Player player in Players) // for each player, make them bet
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet); //passing in our bet value to the Bet function
                if (!successfullyBet)
                {
                    return; //if player dosent have enough for their bet the return brings them back to having to place a bet
                }
                Bets[player] = bet; //adding to the bets dictionary thats in the Game class
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); //check if player got black jack
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); // if they do pay them 1.5x of their bet
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                    }
                }
            }
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
