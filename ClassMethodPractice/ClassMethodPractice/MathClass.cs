using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodPractice
{
    public class MathClass
    {

        public int FirstFunc (int userInt) //notice this is NOT static. We will need to intatiate the class. Thats why i created EricClass in program.cs
        {
            return 2 * userInt;
        }

        public static int SecondFunc (int userInt) // notice this is static. We dont need to intantiate a class to use it. Just use MathClass
        {
            return 2 + userInt;
        }

        public int ThirdFunc (int userInt)
        {
            return userInt - 2;
        }

    }
}
