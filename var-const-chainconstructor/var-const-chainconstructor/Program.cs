using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace var_const_chainconstructor
{
    class Program
    {
        static void Main()
        {
            Person dude = new Person();
            dude.name = "rick";
            dude.writeName();
            ReadLine();

            const string companyName = ("My Company"); //the companys name should always stay the same. So we make is const
            WriteLine("Thanks for doing business with {0}", companyName);
            var person2 = new Person(); //we can use var here because anyone can be sure the data type is person
            ReadLine();
        }
    }
}
