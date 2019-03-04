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
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.ID = 1; //created first employee's info

            Employee employee2 = new Employee();
            employee2.FirstName = "Other";
            employee2.LastName = "Human";
            employee2.ID = 2; // now our second employee

            bool IDcomp = employee == employee2; //all we need to do is use the overloaded operator 
            Console.WriteLine(IDcomp);//print the bool result to the screen
            employee.SayName(employee.FirstName, employee.LastName);
            Console.ReadLine();
        }
    }
}
