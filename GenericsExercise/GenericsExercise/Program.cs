using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Employee<string> employeeStr = new Employee<string>();
            employeeStr.Things = new List<string>() { "eric","mary","joe" };
            Employee<int> employeInt = new Employee<int>();
            employeInt.Things = new List<int>() { 4, 6, 9 };

            foreach (string thing in employeeStr.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employeInt.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
