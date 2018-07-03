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
                employee.Things.Add("desk");
                employee.Things.Add("monitor");
                employee.Things.Add("keyboard");
            }

            Employee<int> employee2 = new Employee<int>();
            {
                employee2.Things.Add(2);
                employee2.Things.Add(10);
                employee2.Things.Add(15);

            }


        }
    }
}
