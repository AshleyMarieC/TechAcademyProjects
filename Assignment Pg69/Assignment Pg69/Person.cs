using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Pg69
{
    public class Person //Base Class
    {
        public string FirstName;
        public string LastName;

    public void SayName()
        {
            Console.WriteLine("Name: " + FirstName +" "+ LastName);
        }
    }

    public class Employee : Person //Derived Class : Base Class
    {
        int ID;
    }
}
