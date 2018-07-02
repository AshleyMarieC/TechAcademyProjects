using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg79
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Ashley", 15632);
            Person person2 = new Person("Jackie", 15645);

            if (person1.ID == person2.ID)
                Console.WriteLine("ID one DOES equal ID two");
            else
                Console.WriteLine("ID one DOES NOT equal ID two");
            Console.ReadLine();

        }
        
    }
}

