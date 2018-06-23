using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTION_HANDLING
{
    class Program
    {
        static void Main()
        {
            //1.Create a list of integers. Ask the user for a number to divide each number in the list by.Write a loop that takes
            //each integer in the list, divides it by the number the user entered, and displays the result to the screen.

            List<int> intList = new List<int>();
            intList.Add(5);
            intList.Add(10);
            intList.Add(15);
            intList.Add(20);

            Console.WriteLine("What number should we divide by?");
            int myNum = Convert.ToInt32(Console.ReadLine());

            foreach (var number in intList)
            {
                var result = number / myNum;
                Console.WriteLine("\n" + result);

            }
            Console.ReadLine();


            //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.
            //Results displayed correctly

            //3.Run that code, entering in zero as the number to divide by. Note any error messages you get.
            //The message I received was "System.DivideByZeroException: 'Attempted to divide by zero.'"


            //4.Run that code, entering in a string as the number to divide by. Note any error messages you get.
            //"System.FormatException: 'Input string was not in a correct format.'"





        }
    }
}
