using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Employee<T> : Person //inheriting from person class
    {
        public List<T> Things { get; set; }
    }
}
