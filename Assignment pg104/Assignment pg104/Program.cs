using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_pg104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please enter a number: ");
            string number = string.Format(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\Ashley\source\repos\log.txt", true))
            {
                file.WriteLine(number);
            }

            //string number = Console.ReadLine();
            //File.WriteAllText(@"C:\Users\Ashley\source\repos\log.txt", number);

           string printNumber = File.ReadAllText(@"C:\Users\Ashley\source\repos\log.txt");
           Console.WriteLine(printNumber);
           Console.ReadLine();
        }
    }
}
