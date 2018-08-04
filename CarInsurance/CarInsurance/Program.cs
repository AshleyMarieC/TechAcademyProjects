using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {

            double baseCharge = 50;

            User user = new User();
            user.firstName = "Ashley";
            user.lastName = "Charneski";
            user.emailAddress = "amcharneski@gmail.com";
            user.carMake = "porsche";
            user.carYear = 1998;
            user.carModel = "911 carrera";
            user.tickets = 2;
            user.dui = true;
            user.birthday = "3/2/1988";
            user.coverage = "full coverage";
            

            DateTime myDateTime = DateTime.Parse(user.birthday);

            int age = 0;
            age = DateTime.Now.Year - myDateTime.Year;
            if (DateTime.Now.DayOfYear < myDateTime.DayOfYear)
            {
                age = -1;
            }

            if (age < 18)
            {
                baseCharge += 100;
            } else if (age < 25 || age > 100)
            {
                baseCharge += 25;
            }

            if (user.carYear < 2000 || user.carYear > 2015)
            {
                baseCharge += 25;
            }

            if (user.carMake == "porsche" && user.carModel == "911 carrera")
            {
                baseCharge += 50;
            } else if (user.carMake == "porsche")
            {
                baseCharge += 25;
            }

            if (user.tickets > 0)
            {
                var ticketTotal = user.tickets * 10;
                baseCharge += ticketTotal;
            }
            if (user.dui == true)
            {
                var duiTotal = baseCharge * .25;
                baseCharge += duiTotal;
            }
            if (user.coverage == "full coverage")
            {
                var coverageTotal = baseCharge * .50;
                baseCharge += coverageTotal;
            }
          
            
            Console.WriteLine(baseCharge);
         

            Console.WriteLine("Hello {0} {1}, your quote for car insurance is ${2}. We will send a copy of this quote to {3}. Thank you, have a great day!", user.firstName, user.lastName, baseCharge, user.emailAddress);
            Console.ReadLine();

        }
    }
}

