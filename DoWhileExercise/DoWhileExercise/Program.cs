using System;

namespace DoWhileExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number!");
            string number = Console.ReadLine();
            int num = Convert.ToInt16(number);

            do
            {
                if (num < 5) { 
                    Console.WriteLine("The current number is " + num + ". Let's add 1 to it!");
                    num++;
                }

                if (num > 5)
                {
                    Console.WriteLine("That number is greater than 5. Try again.");
                    number = Console.ReadLine();
                    num = Convert.ToInt16(number);
                }

                if (num == 5)
                {
                    Console.WriteLine("Your number equals 5 now!");
                    break;
                }
            } while (true);
         Console.ReadLine();
        }
    }
}
