using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredNumbersChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 1234;
            string strInt = Convert.ToString(myInt);
            char[] numbers = strInt.ToCharArray();
            var digits = myInt.ToString().Select(x => int.Parse(x.ToString()));
            List<string> myList = new List<string>();
            foreach (char number in digits)
            {
                int newInt = Convert.ToInt16(number);
                int sqInt = newInt * newInt;
                string strNum = Convert.ToString(sqInt);
                myList.Add(strNum);
            }

            string myString = "";
            
            for (int i = 0; i < myList.Count; i++)
            {
               
                myString = myString + myList[i];
                
            }
            int finalInt = Convert.ToInt32(myString);
            Console.WriteLine(finalInt);
            Console.ReadLine();

        }
    }
}
