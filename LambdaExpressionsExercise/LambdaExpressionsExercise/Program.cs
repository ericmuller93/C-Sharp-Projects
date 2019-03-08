using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsExercise
{
    class Program
    {
        static void Main()
        { 
            Employee employee = new Employee(); //creating employee
            List<Employee> employeeList = new List<Employee>(); //creating a list for our employees
            employee.FirstName = "Rick"; // creating 10 employees to use
            employee.LastName = "Jones";
            employee.ID = 1;
            employeeList.Add(employee);

            Employee employee2 = new Employee();
            employee2.FirstName = "Tim";
            employee2.LastName = "Timmons";
            employee2.ID = 2;
            employeeList.Add(employee2);

            Employee employee3 = new Employee();
            employee3.FirstName = "Joe";
            employee3.LastName = "Smith";
            employee3.ID = 3;
            employeeList.Add(employee3);

            Employee employee4 = new Employee();
            employee4.FirstName = "Gary";
            employee4.LastName = "Johnson";
            employee4.ID = 4;
            employeeList.Add(employee4);

            Employee employee5 = new Employee();
            employee5.FirstName = "John";
            employee5.LastName = "Humans";
            employee5.ID = 5;
            employeeList.Add(employee5);

            Employee employee6 = new Employee();
            employee6.FirstName = "Joe";
            employee6.LastName = "Johnson";
            employee6.ID = 6;
            employeeList.Add(employee6);

            Employee employee7 = new Employee();
            employee7.FirstName = "Albert";
            employee7.LastName = "Hitchcock";
            employee7.ID = 7;
            employeeList.Add(employee7);

            Employee employee8 = new Employee();
            employee8.FirstName = "George";
            employee8.LastName = "Washington";
            employee8.ID = 8;
            employeeList.Add(employee8);

            Employee employee9 = new Employee();
            employee9.FirstName = "Alex";
            employee9.LastName = "Aexsson";
            employee9.ID = 9;
            employeeList.Add(employee9);

            Employee employee10 = new Employee();
            employee10.FirstName = "Luis";
            employee10.LastName = "Hernandez";
            employee10.ID = 10;
            employeeList.Add(employee10);

            List<string> joeList = new List<string>(); //This foreach is looking for people with firstNAme = Joa
            foreach (Employee name in employeeList)
            {
                    if(name.FirstName == "Joe")
                    {
                        joeList.Add(name.FirstName);
                        //Console.WriteLine(name.FirstName + name.LastName);
                    }
            }

            List<Employee> lambdaList = employeeList.Where(x => x.FirstName.Contains("Joe")).ToList();
            foreach (Employee item in lambdaList) //Lambda #1 is looking for people with firstName = Joe
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            List<Employee> id5List = employeeList.Where(x => (x.ID >5)).ToList(); //Lambda #2 looking for ID greater than 5
            Console.WriteLine("The below employees have an ID of greate than 5");
            foreach (Employee item in id5List)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.ID);
            }
            Console.ReadLine();
        }
    }
}
