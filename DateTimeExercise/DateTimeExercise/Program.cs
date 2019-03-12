using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The current date/time is:");
            DateTime time = DateTime.Now; //get current datetime
            Console.WriteLine(time); //print current date time
            Console.WriteLine("Please enter a number!");
            double num = Convert.ToDouble(Console.ReadLine()); //need users num as a double for datetime
            DateTime newHour = time.AddHours(num); //add their number to "times" hour field
            Console.WriteLine("In " + num + " hours it will be " + newHour); //print to the console
            Console.ReadLine();
        }


    }
}
