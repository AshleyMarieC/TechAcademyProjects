using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg106
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Please enter a number: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            DateTime futureTime = DateTime.Now.AddHours(hours);
            Console.WriteLine("It will be {0} in {1} hours from now.",futureTime,hours);

            Console.ReadLine();
        }
    }
}
