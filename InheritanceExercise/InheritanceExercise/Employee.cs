using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Employee : Person //inheriting from person class
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee2) 
        {
            bool IDcomp = employee.ID == employee2.ID; //basically an if statement. Returns true if theyre equal
            return IDcomp;
        }
        public static bool operator!= (Employee employee, Employee employee2) //if you create an overloaded == you need to do a =!
        {
            bool IDcomp = employee.ID != employee2.ID;
            return IDcomp;
        }
    }
}
