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
            Console.WriteLine("Three multiplied by 6  = " + operation.Square(3,6).ToString());
            Console.ReadLine();

         
            Console.WriteLine("11.653 + 11.653 = " + operation.Add(Convert.ToInt32(11.653)).ToString());
            Console.ReadLine();

            Console.WriteLine("Hawaii containes this many letters = " + operation.length("Hawaii").ToString());
            Console.ReadLine();

        }
    }
}
