using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.Add(50);
            Console.WriteLine("Please enter an integer to divide by the numbers in my list"); 
            try
            {
                int userNumber = Convert.ToInt16(Console.ReadLine());
                for (int i = 0; i < myList.Count; i++)
                {
                    int solution = myList[i] / userNumber; //if user entered 0 then this will cause an error, but the divide by zero catch will get this
                    Console.WriteLine(solution);
                }
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
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
