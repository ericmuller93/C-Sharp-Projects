using System;


namespace ShippingQuoteExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            int weight = Convert.ToInt16(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the width of your package?");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the height of your package?");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the length of your package?");
                double length = Convert.ToDouble(Console.ReadLine());

                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    decimal quote = Convert.ToDecimal(width * height * length/100);
                    Console.WriteLine("Your shipping cost is $" + quote);
                    Console.ReadLine();
                }
            }
        }
    }
}
