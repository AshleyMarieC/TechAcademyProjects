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
            
            //Added new exercise 
            
            class2 operation2 = new class2();

            Console.WriteLine("Please Enter A Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Another Number:");
            string num2 = Console.ReadLine();

            if (String.IsNullOrEmpty(num2))
            {
                Console.WriteLine(operation2.multiply(num1, num2: 5).ToString()); Console.ReadLine();
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                Console.WriteLine(operation2.multiply(num1, num3).ToString());
            }
            Console.ReadLine();

        }
    }
}
