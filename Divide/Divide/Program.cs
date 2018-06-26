using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {

            int result1; //pass variable instead of value to void method

            Console.WriteLine("Please Enter A Number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            divMethod.Method(number1, out result1);
            Console.WriteLine("Result is: " + result1);

            Console.ReadLine();



            outMethod Method2 = new outMethod();
            Method2.OutExample(out int number);
            Console.WriteLine(number);
            Console.ReadLine();


            Console.WriteLine(classStatic.MyStruct.num4);
            Console.ReadLine();

        }
    }
}
