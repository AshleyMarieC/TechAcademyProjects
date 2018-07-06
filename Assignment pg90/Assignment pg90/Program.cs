using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg90
{
    class Program
    {
   
         public string firstName { get; set; }
         public string lastName { get; set; }
         public int id { get; set; }
            
      
        static void Main(string[] args)
        {
            
            List<Program> employee = new List<Program>();
            employee.Add(new Program() { firstName = "Joe", lastName = "Smith", id = 1586 });
            employee.Add(new Program() { firstName = "Joe", lastName = "Jacobs", id = 5689 });
            employee.Add(new Program() { firstName = "Chris", lastName = "Brown", id = 4521 });
            employee.Add(new Program() { firstName = "Sarah", lastName = "Smiley", id = 7582 });
            employee.Add(new Program() { firstName = "Ashley", lastName = "Marie", id = 4682 });
            employee.Add(new Program() { firstName = "Alex", lastName = "Fields", id = 3759 });
            employee.Add(new Program() { firstName = "Sam", lastName = "Carl", id = 3658 });
            employee.Add(new Program() { firstName = "Jackie", lastName = "Souza", id = 6542 });
            employee.Add(new Program() { firstName = "Bob", lastName = "Todd", id = 9541 });
            employee.Add(new Program() { firstName = "Joe", lastName = "James", id = 7463 });

            List<Program> Joe = new List<Program>();
            foreach (Program name in employee)
                if (name.firstName == "Joe")
                {
                    Joe.Add(name);
                    Console.WriteLine(name.firstName + " " + name.lastName + " " + name.id);
                }

            Console.WriteLine("\n");

            List<Program> newList = employee.Where(x => x.firstName == "Joe").ToList();
            foreach(Program joe in newList)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName + " " + joe.id);
            }
            Console.WriteLine("\n");

            List<Program> idGreaterThanFive = employee.Where(x => x.id > 5).ToList();
            foreach (Program greaterThanFive in idGreaterThanFive)
            {
                Console.WriteLine(greaterThanFive.firstName + " " + greaterThanFive.lastName + " " + greaterThanFive.id);
            }

            Console.ReadLine();
        }
    }
}      
    

