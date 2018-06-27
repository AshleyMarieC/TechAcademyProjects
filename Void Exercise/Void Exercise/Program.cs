using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int result3; //pass variable instead of value to void method
            int result2;

            int number4 = 50;
            int number5 = 10;

            voidClass.Method(number4, number5, out result3, out result2);
            Console.WriteLine(result3);
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}
