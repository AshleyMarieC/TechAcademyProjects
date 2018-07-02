using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg._74
{
    public class Employee : Person
    {
        public override void SayName()
        {
            //throw new NotImplementedException();
            Console.WriteLine(FirstName +  " " + LastName);
        }

    }
}
