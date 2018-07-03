using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg81
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employee = new Employee<string>();
            {
                employee.Things = new List<string>
                {
                    "monitor", "keyboard", "desk"
                };

                foreach (var thing in employee.Things)
                {
                    Console.WriteLine(thing);
                }
            }
    

            Employee<int> employee2 = new Employee<int>();
            {
                employee2.Things = new List<int>
                {
                    2,10,15
                };

                foreach (var thing in employee2.Things)
                {
                    Console.WriteLine(thing);
                }

            }

            Console.ReadLine();


        }
    }
}
