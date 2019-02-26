using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please Enter 3 Strings!");
        string[] myStrings = {Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };
        for (int i = 0; i < myStrings.Length; i++) //if I didnt i++ here it would create an infinite loop
        {
            Console.WriteLine(myStrings[i]);
        }

        int[] myTemps = { 99, 85, 75, 60, 50, 30 };
        foreach (int temp in myTemps)
        {
            if(temp < 60)
            {
                Console.WriteLine("The temp " + temp + " is chilly");
            }
        }

        int[] mySpeeds = { 80, 70, 50, 30, 25, 20, 15 };
        foreach (int speed in mySpeeds)
        {
            if (speed <= 25)
            {
                Console.WriteLine("The speed " + speed + " is acceptable in the school zone.");
            }
        }

        //1st larger exercise
        List<string> myList = new List<string>();
        myList.Add("a"); //add some values to the list
        myList.Add("b");
        myList.Add("c");
        myList.Add("d");
        myList.Add("e");
        Console.WriteLine("Please enter text to search for in myList");
        string searchText = Console.ReadLine(); //what the user enters
        bool loop1 = false; //set this so our while loop starts
        while (loop1 == false)
        {
            for (int i = 0; i < myList.Count; i++) //have this run through every value 
            {
                if (searchText == myList[i])
                {
                    Console.WriteLine(searchText + " is at at index " + i);
                    loop1 = true; //make this true so when the for is done we leave it and the while will end
                }
                if (!myList.Contains(searchText)) // is our value in this list at all?
                {                                 // if not just end everything and tell user
                    Console.WriteLine(searchText + " is not in this list.");
                    loop1 = true; //this is different so we end the while but we will also end the 
                    break;        // for. So everything is ended because
                }
            }
        }

        //second larger exercise but same thing as above
        List<string> secondList = new List<string>();
        secondList.Add("a");
        secondList.Add("a");
        secondList.Add("b");
        secondList.Add("c");
        secondList.Add("d");
        Console.WriteLine("Please enter text to search for in secondList");
        string secondSearchText = Console.ReadLine();
        bool loop2 = false;
        while (loop2 == false)
        {
            for(int i = 0; i < secondList.Count; i++)
            {
                if(secondSearchText == secondList[i])
                {
                    Console.WriteLine(secondSearchText + " is at at index " + i);
                    loop2 = true;
                }
                if(!secondList.Contains(secondSearchText))
                {
                    Console.WriteLine(secondSearchText + " is not in this list.");
                    loop2 = true;
                    break;
                }
            }
        }
        Console.ReadLine();
        }
    }