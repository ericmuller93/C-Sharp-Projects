using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClassMethodPractice2
{
    class MyClass
    {
        public int myMethod(int Int1, out int result)
        {
            result = Int1 * 2;
            return result;
        }

        public decimal myMethod(decimal Int2, out int result2)
        {
            decimal answer = Int2 * 100;
            result2 = Convert.ToInt16(answer);
            return result2;
        }

        public int myMethod(string Int3, out int result3)
        {
            int answer = Convert.ToInt16(Int3);
            result3 = answer + 111;
            return result3;
        }
    }
}
