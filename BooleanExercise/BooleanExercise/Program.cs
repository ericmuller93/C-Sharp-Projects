using System;

namespace BooleanExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Car Insurance Approval Questionnaire!");
            Console.WriteLine("What is your age?");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt16(ageStr);
            Console.WriteLine("Have you ever had a DUI? (true or false)");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets have you had?");
            string ticketsStr = Console.ReadLine();
            int tickets = Convert.ToInt16(ticketsStr);
            bool qualified = (age > 15 && dui == "false" && tickets <= 3);
            Console.WriteLine("Qualified for Insurace?: "+ qualified);
            Console.ReadLine();
        }
    }
}
