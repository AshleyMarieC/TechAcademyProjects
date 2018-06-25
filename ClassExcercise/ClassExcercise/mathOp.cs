using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise
{
    public class mathOp
    {
        public int Square(int num1, int num2)
        {
            return num1 * num2;
        }
        public decimal Add(decimal num1)
        {
            return num1 + num1;
        }
        public string length(string string1)
        {
            return Convert.ToString(string1.Length);
        }
    }
}
