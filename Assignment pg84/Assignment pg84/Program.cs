using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg84
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week: ");
            var input = Console.ReadLine();
            input = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);

            try
            {
                DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);

                Console.WriteLine("{0} seems like a good day to leave work early!", today);
            }
            catch
            {
                Console.WriteLine(input + " is not a day of the week! Please enter an actual day of the week.");
            }

            Console.ReadLine();
            
        }


        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
