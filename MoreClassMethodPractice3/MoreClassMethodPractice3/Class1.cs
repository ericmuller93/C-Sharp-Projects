using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClassMethodPractice3
{
    class Class1
    {
        public int myMethod(int int1, int newInt2 = 1)
        {
           int int3 = int1 + newInt2;
           return int3;
        }
    }
}
