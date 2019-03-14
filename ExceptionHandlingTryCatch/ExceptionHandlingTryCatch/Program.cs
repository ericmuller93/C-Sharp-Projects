using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionHandlingTryCatch
{
    class Program
    {
        static void Main()
        {
            int age = -4;
            bool validAnswer = false;
            while (!validAnswer)
            {
                try
                {
                    Console.WriteLine("Whats your age?");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 0)
                    {
                        Console.WriteLine("Age is only positive numbers!");
                    }
                    else
                    {
                        Console.WriteLine("You are {0} years old.", age);
                        validAnswer = true;
                        Console.ReadLine();
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please only enter digits!");
                }
                catch (Exception)
                {
                    Console.WriteLine("There seems to have been an error, please start over.");
                }
            }
        }
    }
}
