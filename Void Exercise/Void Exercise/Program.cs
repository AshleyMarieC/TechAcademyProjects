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

            voidClass VoidClass = new voidClass();

            VoidClass.Method(number4:16, number2: 10);

            Console.WriteLine(voidClass.result);
            Console.ReadLine();
        }
    }
}

