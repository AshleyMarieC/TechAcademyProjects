using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            mathOp operation = new mathOp();
            Console.WriteLine("Three multiplied by 6  = " + operation.classExercise(3, 6).ToString());
            Console.ReadLine();

            mathOp operation1 = new mathOp();
            Console.WriteLine("11.653 + 11.653 = " + operation1.classExercise(Convert.ToDecimal(11.653)).ToString());
            Console.ReadLine();

            mathOp op1 = new mathOp();
                Console.WriteLine(op1.classExercise("2"));
                Console.ReadLine();
        }
    }
}
            
