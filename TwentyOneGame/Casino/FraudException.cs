using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        public FraudException()
            : base() { } //base means this constructor is inheriting from the base constructor (in Exception)
        public FraudException(string message)
            : base(message) { }
    }
}
