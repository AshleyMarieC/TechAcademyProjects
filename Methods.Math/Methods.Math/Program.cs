using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to do the math operations on?: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            BasicMath sq = new BasicMath();
            Console.WriteLine(num1 + " x " + num1 + " = " + sq.Square(num1).ToString());
            Console.WriteLine(num1 + " + " + num1 + " = " + sq.Add(num1).ToString());
            Console.WriteLine(num1 + " - " + num1 + " = " + sq.Subtract(num1).ToString());
            Console.ReadLine();
        }

    
    }
}
