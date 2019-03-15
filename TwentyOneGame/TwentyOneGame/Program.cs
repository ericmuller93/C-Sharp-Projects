using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino; //we added these casino items as a reference so program can access them.
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Lets start by telling me your name.");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer) //exception handling for how much money they brought. we want only an int
            {
                Console.WriteLine("And how much money did you bring today?");
                //tryparse will convert the readline string to an integer and return it as var bank. If it succeeds valid answer is true if nto its false.
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            //Console.WriteLine("How much money did you bring today");
            //int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to play a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yea" || answer == "yeah" || answer == "yep")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid(); //assigning a globally unique ID for our player
                using (StreamWriter file = new StreamWriter(@"C:\Users\ericm\OneDrive\Documents\users.txt", true))
                { //this will log our players ID to a file.
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)//exception for that especific error, this is used in bet.
                    {
                        Console.WriteLine("Security!! Kick this person out!"); //this runs if you try to put a neg number which is cheating
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex) //an exception for any general error
                    {
                        Console.WriteLine("An error occured please contact your system admin.");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return; //we end the program with this
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.ReadLine();
        }

        private static void UpdateDBWithException(Exception ex) //creating our database logger method. we have to pass in exceptions to log
        { //this connectionstring was copied from our SQL server object explorer
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            //below is the actual query we want to use, the @s will fill in
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                  (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            //using this to shut off our connection. dont want to leave connections open!
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar); //adding datatypes of these items
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.VarChar);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); //these are the actual values we wil be inserting
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now; //not passing in value from the message. just the time it happened 

                connection.Open();
                command.ExecuteNonQuery(); //not a query because we are just inserting
                connection.Close();

            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";
            string queryString = @"SELECT id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions";
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}

    
    
    
    
    
    
    //everything below here is practice info when creating the program. Not be be used for prod
    
    //class Program
    //{
        //static void Main(string[] args)
        //{
            //Deck deck = new Deck(); //creating a new deck item named deck
        //    deck.Shuffle(3); //here we are reassigning deck to what deck becomes when shuffle method is applied. For why an int is here check out line 53.

        //    foreach (Card card in deck.Cards)
        //    {
        //        Console.WriteLine(card.Face + " of " + card.Suit);
        //    }
        //    Console.WriteLine(deck.Cards.Count);
        //    Console.ReadLine();
        //}
        //  THIS IS THE MANUAL WAY THAT I CREATED A CARD IN A DECK WITHOUT THE DECK HAVING THE 
        // CONSTRUCTOR. I WANTED TO KEEP THIS HERE FOR REFERENCE. 

        //Card cardOne = new Card(); //creating a new card, itll be defaulted to 2 of spades
        //cardOne.Face = "Queen";   //but here we are changing that default value
        //cardOne.Suit = "Spades";

        //Deck deck = new Deck(); //creating a new deck item named deck
        //deck.Cards = new List<Card>(); //and now we are using the property cards of deck. Were creating that list for it

        //deck.Cards.Add(cardOne); //now were adding cardOne to that list

        //Console.ReadLine();


        // this is our shuffle function I pasted into deck then edited a bit. I could just keep this here  
        // and call it but we want it as a method of deck.

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

        //use of an overloaded operator
        //game game = new twentyonegame();
        //game.players = new list<player>();
        //    player player = new player();
        //player.name = "jesse";
        //    game = game + player;

