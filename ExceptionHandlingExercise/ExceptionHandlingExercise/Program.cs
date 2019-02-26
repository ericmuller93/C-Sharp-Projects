using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Pick a number. \n");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Pick another number. \n");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lets divide the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            }

            catch (FormatException) //if a format exception put the below message
            {
                Console.WriteLine("Please type a whole number"); // custom error message
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }

            catch (Exception ex) //need to put ex here if you want the generic error message
            {
                Console.WriteLine(ex.Message); // ex.Message will enter your generic error message
            }

            finally // this is here because it will take place no matter what
            {       // so we will have this read line no matter errors or not
                Console.ReadLine();
            }   
        }
    }
