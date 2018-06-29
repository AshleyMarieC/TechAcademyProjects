using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Page63
{
    class Program
    {
        static void Main(string[] args)
        {
            class2 operation2 = new class2();

            Console.WriteLine("Please Enter A Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Another Number, but you don't have to!:");
            string num2 = Console.ReadLine();

            if (String.IsNullOrEmpty(num2))
            {
                Console.WriteLine(operation2.multiply(num1, num2: 5));
                Console.ReadLine();
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                Console.WriteLine(operation2.multiply(num1, num3));
            }
            Console.ReadLine();
        }
    }
}
