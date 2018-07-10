using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_pg116
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Hello, How old are you?");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0)
                {
                    throw new ArgumentException();
                }

                var todaysDate = DateTime.Today.Year;
                var birthYear = todaysDate - age;
                Console.WriteLine("It looks like you were born in {0}", birthYear);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("I'm sorry, you can not enter 0 or a negative number");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR: Please enter your age using numbers only");
                Console.ReadLine();
                return;
            }

            Console.ReadLine();
        }
    }
}
