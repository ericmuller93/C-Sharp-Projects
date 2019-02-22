using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] strArray = { "hello", "how", "are", "you", "doing" }; //short hand way of creating and adding data to this new array
        Console.WriteLine("Please choose an array value 0-4 and we will display the string inside!");
        string userInputStr = Console.ReadLine();
        int userInputStr1 = Convert.ToInt16(userInputStr); // convert that string input so it can be used as an int
        bool firstBool = true; // these three bools are too be used in the below while statements
        bool secondBool = true;
        bool thirdBool = true;

        while (firstBool==true)
        {
            switch (userInputStr1)
            {
                case 0: 
                    Console.WriteLine("The string at that array value is: " + strArray[userInputStr1]);
                    firstBool = false; //this while make us exit the while because we are done
                    break;
                case 1:
                    Console.WriteLine("The string at that array value is: " + strArray[userInputStr1]);
                    firstBool = false;
                    break;
                case 2:
                    Console.WriteLine("The string at that array value is: " + strArray[userInputStr1]);
                    firstBool = false;
                    break;
                case 3:
                    Console.WriteLine("The string at that array value is: " + strArray[userInputStr1]);
                    firstBool = false;
                    break;
                case 4:
                    Console.WriteLine("The string at that array value is: " + strArray[userInputStr1]);
                    firstBool = false;
                    break;
                default: //this is the back up in case they enter an invalid number
                    Console.WriteLine("Your number was not between 0 and 4!");
                    Console.WriteLine("Try again!");
                    userInputStr = Console.ReadLine();
                    userInputStr1 = Convert.ToInt16(userInputStr);
                    break;

            }
        }

        int[] intArray = {4,15,7,99,1056}; //below does the same as the above but but an int array
        Console.WriteLine("Please choose an array value 0-4 and we will display the integer inside!");
        string userInputInt = Console.ReadLine();
        int userInputInt1 = Convert.ToInt16(userInputInt);
        while (secondBool == true)
        {
            switch (userInputInt1)
            {
                case 0:
                    Console.WriteLine("The string at that array value is: " + intArray[userInputInt1]);
                    secondBool = false;
                    break;
                case 1:
                    Console.WriteLine("The string at that array value is: " + intArray[userInputInt1]);
                    secondBool = false;
                    break;
                case 2:
                    Console.WriteLine("The string at that array value is: " + intArray[userInputInt1]);
                    secondBool = false;
                    break;
                case 3:
                    Console.WriteLine("The string at that array value is: " + intArray[userInputInt1]);
                    secondBool = false;
                    break;
                case 4:
                    Console.WriteLine("The string at that array value is: " + intArray[userInputInt1]);
                    secondBool = false;
                    break;
                default:
                    Console.WriteLine("Your number was not between 0 and 4!");
                    Console.WriteLine("Try again!");
                    userInputInt = Console.ReadLine();
                    userInputInt1 = Convert.ToInt16(userInputInt);
                    break;

            }
        }

        List<string> list = new List<string>(); //do all of the same but for a list of strings
        list.Add("hi"); // add some string data to this list
        list.Add("again");
        list.Add("welcome");
        list.Add("back");
        list.Add("friend");
        Console.WriteLine("Please choose an array value 0-4 and we will display the string inside!");
        string userInputList = Console.ReadLine();
        int userInputList1 = Convert.ToInt16(userInputList);

        while (thirdBool == true)
        {
            switch (userInputList1)
            {
                case 0:
                    Console.WriteLine("The string at that array value is: " + list[userInputList1]);
                    thirdBool = false;
                    break;
                case 1:
                    Console.WriteLine("The string at that array value is: " + list[userInputList1]);
                    thirdBool = false;
                    break;
                case 2:
                    Console.WriteLine("The string at that array value is: " + list[userInputList1]);
                    thirdBool = false;
                    break;
                case 3:
                    Console.WriteLine("The string at that array value is: " + list[userInputList1]);
                    thirdBool = false;
                    break;
                case 4:
                    Console.WriteLine("The string at that array value is: " + list[userInputList1]);
                    thirdBool = false;
                    break;
                default:
                    Console.WriteLine("Your number was not between 0 and 4!");
                    Console.WriteLine("Try again!");
                    userInputList = Console.ReadLine();
                    userInputList1 = Convert.ToInt16(userInputList);
                    break;

            }
        }
        Console.ReadLine();
    }
}

