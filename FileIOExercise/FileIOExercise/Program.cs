using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your favorite number my dude");
            string num = Console.ReadLine();
            File.WriteAllText(@"C:\Users\ericm\OneDrive\Documents\text.txt", num); //this will write the num variable contents to the text.txt file.
            string fileNum = File.ReadAllText(@"C:\Users\ericm\OneDrive\Documents\text.txt"); //this will display the contents of the text.txt file.
            Console.WriteLine(fileNum);
            Console.ReadLine();

        }
    }
}
