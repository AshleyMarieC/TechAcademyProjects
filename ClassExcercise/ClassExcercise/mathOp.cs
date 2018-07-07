using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise
{
    public class mathOp
    {
        public int classExercise(int num1, int num2)
        {
            return num1 * num2;
        }
        public decimal classExercise(decimal num1)
        {
            return Convert.ToInt32(num1 + num1);

        }
        public int classExercise(string string1)
        {
            try
            {
                int int1 = Convert.ToInt32(string1);
                return int1 + int1;
            }
            catch
            {
                Console.WriteLine("I'm sorry, but that conversion can not take place");
                return 0;
            }
        }
    }
}

