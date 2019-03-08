using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsExercise
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName(string FirstName, string LastName)
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
