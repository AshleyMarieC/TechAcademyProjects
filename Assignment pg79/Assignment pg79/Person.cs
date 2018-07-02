using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg79
{
    class Person
    {
        public string Employee;
        public int ID;
        public Person(string Employee, int ID)
        {
            this.Employee = Employee;
            this.ID = ID;
        }
        public static bool operator ==(Person person1, Person person2)
        {
            if (person1.Employee == person2.Employee &&
             person1.ID == person2.ID)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }

        public override bool Equals(object obj)
        {
           if (!(obj is Person))
           {
               return false;
           }
           return this == (Person)obj;
        }
    }
}
