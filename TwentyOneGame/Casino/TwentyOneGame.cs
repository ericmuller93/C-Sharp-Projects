using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
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
            Dealer.Deck.Shuffle();

            foreach (Player player in Players) // for each player, make them bet
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    //tryparse will convert the readline string to an integer and return it as var bank. If it succeeds valid answer is true if nto its false.
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }
                if(bet < 0)
                {
                    throw new FraudException(); //if they enter a neg number it is cheating. call this exception
                }
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
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are...");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.isBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player]; //if you bust dealer gets your bet
                        Console.WriteLine("{0} Busted! You lose you bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yea" || answer == "yeah" || answer == "yep")
                        {
                            player.IsActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.IsActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.isBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted) //dealer hits
            {
                Console.WriteLine("Deal is hitting...");
                Dealer.Deal(Dealer.Hand); //add a card to dealers hand
                Dealer.isBusted = TwentyOneRules.isBusted(Dealer.Hand); //check if dealer busted
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //check is dealer stayed (one of these has to be true)
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is Staying....");
            }
            if (Dealer.isBusted) // dealer lost so all players win
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets) //for each winner
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); //write a winners name ot the console
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //If they won find them in our dictionary and add their winnings to balance
                    Dealer.Balance -= entry.Value; //subtract bets from dealers balance
                }
            }
            foreach (Player player in Players) //comparing players hands to dealers to see who wins
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);//the ? makes it so that the bool value can be null, that way it can have 3 values
                if (playerWon == null) //if theres a tie
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true) //if player wins
                {
                    Console.WriteLine("{0} wins {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else // if dealer wins
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer2 = Console.ReadLine().ToLower();
                if (answer2 == "yes" || answer2 == "yea" || answer2 == "yeah" || answer2 == "yep")
                {
                    player.IsActivelyPlaying = true;
                }
                else
                {
                    player.IsActivelyPlaying = false;
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
