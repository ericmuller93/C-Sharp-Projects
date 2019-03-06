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
                bool isNum = Int32.TryParse(userDay, out int number);
                if (isNum == false)
                {
                    Console.WriteLine(Enum.Parse(typeof(DaysOfTheWeek), userDay));
                }
                if (isNum)
                {
                    Console.WriteLine("Please don't enter numbers!");
                }
                
            }
            catch
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
