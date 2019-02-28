using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClassMethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first Int!");
            int Int1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter your second Int!");
            int Int2 = Convert.ToInt16(Console.ReadLine());
            MathStuff myClass = new MathStuff();
            myClass.myFunc(Int1, Int2);
            Console.ReadLine();
        }
    }
}
