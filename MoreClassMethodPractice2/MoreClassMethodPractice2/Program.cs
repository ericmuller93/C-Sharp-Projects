using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClassMethodPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an Int!");
            int Int1 = Convert.ToInt16(Console.ReadLine());
            MyClass firstClass = new MyClass();
            firstClass.myMethod(Int1, out int result);
            Console.WriteLine(result + " is the result of your int in my first Method");
            Console.WriteLine("Please enter another Int!");
            decimal Int2 = Convert.ToDecimal(Console.ReadLine());
            MyClass secondClass = new MyClass();
            secondClass.myMethod(Int2, out int result2);
            Console.WriteLine(result2 + " is the result of your int in my second Method");
            Console.WriteLine("Please enter another Int!");
            string Int3 = Console.ReadLine();
            MyClass thirdClass = new MyClass();
            thirdClass.myMethod(Int3, out int result3);
            Console.WriteLine(result3 + " is the result of your int in my third Method");
            Console.ReadLine();
        }
    }
}
