using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg90
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee() { firstName = "Joe", lastName = "Smith", id = 1 });
            employee.Add(new Employee() { firstName = "Joe", lastName = "Jacobs", id = 56 });
            employee.Add(new Employee() { firstName = "Chris", lastName = "Brown", id = 4 });
            employee.Add(new Employee() { firstName = "Sarah", lastName = "Smiley", id = 75 });
            employee.Add(new Employee() { firstName = "Ashley", lastName = "Marie", id = 3 });
            employee.Add(new Employee() { firstName = "Alex", lastName = "Fields", id = 37 });
            employee.Add(new Employee() { firstName = "Sam", lastName = "Carl", id = 36 });
            employee.Add(new Employee() { firstName = "Jackie", lastName = "Souza", id = 65 });
            employee.Add(new Employee() { firstName = "Bob", lastName = "Todd", id = 95 });
            employee.Add(new Employee() { firstName = "Joe", lastName = "James", id = 74 });

            List<Employee> Joe = new List<Employee>();
            foreach (Employee name in employee)
                if (name.firstName == "Joe")
                {
                    Joe.Add(name);
                    Console.WriteLine(name.firstName + " " + name.lastName + " " + name.id);
                }

            Console.WriteLine("\n");

            List<Employee> newList = employee.Where(x => x.firstName == "Joe").ToList();
            foreach(Employee joe in newList)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName + " " + joe.id);
            }
            Console.WriteLine("\n");

            List<Employee> idGreaterThanFive = employee.Where(x => x.id > 5).ToList();
            foreach (Employee greaterThanFive in idGreaterThanFive)
            {
                Console.WriteLine(greaterThanFive.firstName + " " + greaterThanFive.lastName + " " + greaterThanFive.id);
            }

            Console.ReadLine();
        }
    }
}      
    


