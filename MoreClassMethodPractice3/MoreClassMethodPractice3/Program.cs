using System;


namespace MoreClassMethodPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer");
            int int1 = Convert.ToInt16(Console.ReadLine());
            int newInt2 = 1;
            Console.WriteLine("OPTIONAL Please enter another integer");
            string int2 = Console.ReadLine(); //have to keep this as a string to see if its null. then convert if they give an int
            if (!string.IsNullOrWhiteSpace(int2)) //if they entered a value do the below. Else give the null which will refer to the default value
            {
                newInt2 = Convert.ToInt16(int2);
            }
         
            Class1 myClass = new Class1();
            Console.WriteLine("Your inputs in the method equal " + myClass.myMethod(int1, newInt2));
            Console.ReadLine();

        }
    }
}
