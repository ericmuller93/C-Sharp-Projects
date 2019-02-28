using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an int! \n");
            int userInt = Convert.ToInt16(Console.ReadLine());
            MathClass EricClass = new MathClass(); //making the method static I dont exactly need to make an instance of if
            int result1 = EricClass.FirstFunc(userInt); //I put EricClass here because our FirstFunc is not public
            Console.WriteLine("That number (" + userInt + ") times 2 is " + result1);
            int result2 = MathClass.SecondFunc(userInt); //notice this is MathClass because SeconFunc IS public.
            Console.WriteLine(userInt + " plus 2 is " + result2);
            int result3 = EricClass.ThirdFunc(userInt);
            Console.WriteLine(userInt + " minus 2 is " + result3);
            Console.ReadLine();
        }
    }
}
