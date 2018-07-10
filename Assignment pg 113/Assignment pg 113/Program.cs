using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg_113
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Ashley";
            var myAge = 31;

            var person = new Person(myName, myAge);
            Console.WriteLine("Hello, my name is {0} and I am {1} years old", myName, myAge);

            var chainedPerson = new Person(myName);
            Console.WriteLine("Hello, my name is {0} and I am {1} years old",myName, person.Age);

            Console.ReadLine();
        }
    }
}
