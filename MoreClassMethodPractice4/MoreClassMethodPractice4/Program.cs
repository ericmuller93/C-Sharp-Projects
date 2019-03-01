using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClassMethodPractice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 myClass = new Class1();
            Console.WriteLine("Please enter an Int");
            int userInt = Convert.ToInt16(Console.ReadLine());
            myClass.myMethod(userInt);
            myClass.secondMethod(userInt, out int Int3);
            Console.WriteLine("Your Int in the second method is " + Int3);
            Console.WriteLine("Please enter another Int and it will be added to your first int.");
            int userInt2 = Convert.ToInt16(Console.ReadLine());
            myClass.myMethod(userInt, userInt2);
            Console.WriteLine("Finally, give one more int to be used in the static function please!");
            int userInt3 = Convert.ToInt16(Console.ReadLine()); // static methods dont need to be instantiated. 
            Console.WriteLine("Used in the satic method that is " + Class1.staticMethod(userInt3)); //Just call the class and function as I do here
            Console.ReadLine();

        }
    }
}
