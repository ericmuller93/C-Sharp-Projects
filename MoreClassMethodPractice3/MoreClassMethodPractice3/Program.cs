using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string int2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(int2))
            {
                
            }
            else
            {
                newInt2 = Convert.ToInt16(int2);
            }
            Class1 myClass = new Class1();
            Console.WriteLine("Your inputs in the method equal " + myClass.myMethod(int1, newInt2));
            Console.ReadLine();

        }
    }
}
