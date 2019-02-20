using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
        Console.WriteLine("What Page Number?");
        string pageNum = Console.ReadLine();
        int intPageNum = Convert.ToInt16(pageNum);
        Console.WriteLine("Do you need help with anything? Please answer True or False");
        string helpStr = Console.ReadLine();
        bool helpBool = Convert.ToBoolean(helpStr);
        Console.WriteLine("Were there any positive experiences youd like to share? Please give specifics.");
        string exp = Console.ReadLine();
        Console.WriteLine("Is there any other feedback youd like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string hours = Console.ReadLine();
        int intHours = Convert.ToInt16(hours);
        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}