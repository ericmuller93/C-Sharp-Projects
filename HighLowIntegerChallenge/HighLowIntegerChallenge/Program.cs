using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowIntegerChallenge
{
    class Program
    {
        static void Main()
        {
            int[] myArray = { 6, 3, 2, 3, 4, 5, 9, 11, 5 };
            int min = myArray.Min();
            int max = myArray.Max();
            Class1 myClass = new Class1();
            myClass.HighLowIntFunc(min, max);
            Console.ReadLine();

        }
    }
}
