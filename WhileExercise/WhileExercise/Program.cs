using System;
namespace WhileExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Give a number less than 5 and we will count up to it");
            string input = Console.ReadLine();
            int number = Convert.ToInt16(input);
            while (number != 5)
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("0. Lets add 1 to it!");
                        number++;
                        break;
                    case 1:
                        Console.WriteLine("1. Lets add 1 to it!");
                        number++;
                        break;
                    case 2:
                        Console.WriteLine("2. Lets add 1 to it!");
                        number++;
                        break;
                    case 3:
                        Console.WriteLine("3. Lets add 1 to it!");
                        number++;
                        break;
                    case 4:
                        Console.WriteLine("4. Lets add 1 to it!");
                        number++;
                        break;
                    default:
                        Console.WriteLine("That number dosent work for this. Try again");
                        input = Console.ReadLine();
                        number = Convert.ToInt16(input);
                        break;

                }
            }
            Console.WriteLine("Great! Now the number is " + number);
            Console.ReadLine();
        }
    }
}
