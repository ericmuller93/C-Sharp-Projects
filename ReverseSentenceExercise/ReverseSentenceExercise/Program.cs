using System;


namespace ReverseSentenceExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a sentence and I will reverse all of the letters in the words!");
            string myString = Console.ReadLine();
            Class1 myclass = new Class1();
            Console.WriteLine(myclass.MyFunc(myString));
            Console.ReadLine();

        }
    }
}
