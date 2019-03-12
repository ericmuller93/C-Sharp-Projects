using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentenceExercise
{
    class Class1
    {
        public string MyFunc(string myString)
        {

            string[] parsed = myString.Split(' ');
            string final = "";
            foreach (string word in parsed)
            {
                string result = "";
                foreach (char letter in word)
                {
                    result = letter + result;
                }
                final = final + result + " ";
            }
            return final;
        }
    }
}
