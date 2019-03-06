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
                Console.WriteLine(Enum.Parse(typeof(DaysOfTheWeek), userDay));
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
