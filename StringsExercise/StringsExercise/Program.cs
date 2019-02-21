using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExercise
{
    class Program
    {
        static void Main()
        {
            string text1 = "My name is";
            string text2 = "Eric";
            text2 = text2.ToUpper(); //this converts text 2 to all upper case
            StringBuilder myParagraph = new StringBuilder("I hope you are doing well today \n");
            myParagraph.Append(text1 +"\n"); //here we start concatnating our strings
            myParagraph.Append(text2 + "\n");
            myParagraph.Append("And I think cheese is tasty.");
            Console.WriteLine(myParagraph);
            Console.ReadLine();
        }
    }
}
