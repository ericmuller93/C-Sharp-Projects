using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClassMethodPractice4
{
    class Class1
    {
        public void myMethod(int userInt) //void method
        {
            int Int2 = userInt / 2;
            Console.WriteLine("Your entered Int in the \"myMethod\" method is " + Int2);
        }

        public int secondMethod(int userInt, out int Int3) //method with output 
        {
            Int3 = userInt * 10;
            return Int3;
        }

        public void myMethod(int userInt, int userInt2) //overloaded method
        {
            int result = userInt + userInt2;
            Console.WriteLine("Your two ints added together equals " + result);
        }

        public static int staticMethod(int userInt3) //static method
        {
            return 19 + userInt3;
        }
    }
}
