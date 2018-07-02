using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg76
{
        public class Employee : Person, IQuittable
        {
            public override void SayName()
            {
                //throw new NotImplementedException();
                Console.WriteLine(FirstName + " " + LastName);
            }

            public void Quit()
            {
            Console.WriteLine("I quit!");
            }

        }
    
}
