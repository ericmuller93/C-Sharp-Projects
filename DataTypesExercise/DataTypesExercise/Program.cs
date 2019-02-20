using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number!");
            string firstNum = Console.ReadLine();
            double firstAnswer = Convert.ToDouble(firstNum) * 50;
            Console.WriteLine("Your number times 50 is " + firstAnswer);
            Console.WriteLine("Please enter another number!");
            string secondNum = Console.ReadLine();
            double secondAnswer = Convert.ToDouble(secondNum) + 25;
            Console.WriteLine("Your number plus 25 is " + secondAnswer);
            Console.WriteLine("Please enter another number!");
            string thirdNum = Console.ReadLine();
            double thirdAnswer = Convert.ToDouble(thirdNum) / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + thirdAnswer);
            Console.WriteLine("Please enter another number!");
            string fourthNum = Console.ReadLine();
            double fourthNumDub = Convert.ToDouble(fourthNum);
            bool fourthAnswer = (fourthNumDub > 50);
            Console.WriteLine("Is your number greater than 50?: " + fourthAnswer);
            Console.WriteLine("Please enter another number!");
            string fifthNum = Console.ReadLine();
            double fifthAnswer = Convert.ToDouble(fifthNum) % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + fifthAnswer);

            Console.ReadLine();

        }
    }
}

