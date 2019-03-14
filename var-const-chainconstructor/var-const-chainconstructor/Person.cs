using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace var_const_chainconstructor
{
    public class Person
    {
        public string name { get; set;}
        public string country { get; set; }
        public int age { get; set; }

        public Person(): this("")
        {
            name = "eric";
        }

        public Person(string name)
        {
            age = 20;
            country = "Germany";
        }
        public void writeName()
        {
            WriteLine(name);
            WriteLine(age);
        }
    }
}
