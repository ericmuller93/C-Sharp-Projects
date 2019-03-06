using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumExercise;
namespace EnumExercise
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter a day of the week! (lowercase)");
                string userDay = Console.ReadLine();
                bool isNum = Int32.TryParse(userDay, out int number); //this is checking if a number was entered. if so it returns true
                if (isNum == false) //we only want false (no numbers). first if will move on with program
                {
                    Console.WriteLine(Enum.Parse(typeof(DaysOfTheWeek), userDay)); //checking if user input perfectly matches values in our enum. Try catch will pick up if they enter something thats not a match.
                }
                if (isNum) //if they entered a number tell them no numbers
                {
                    Console.WriteLine("Please don't enter numbers!");
                }
                
            }
            catch //catch will pickup if they entered letters that dont match with our days in the enum
            {
                Console.WriteLine("Please enter an actual day of the week in lowercase!");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
