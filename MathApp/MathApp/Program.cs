using System;

namespace MathApp
{
    class Program
    {
        static void Main()
        {
            //1.Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
            Console.WriteLine("Please enter a number:");
            string myNum = Console.ReadLine();
            int total = Convert.ToInt32(myNum) * 50;
            Console.WriteLine("Your number * 50 = " + total + "\nPress enter for the next math problem...");
            Console.ReadLine();

            //2.Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Please enter a number:");
            string secNum = Console.ReadLine();
            int secTotal = Convert.ToInt32(secNum) + 25;
            Console.WriteLine("Your number + 25 = " + secTotal + "\nPress enter for the next math problem...");
            Console.ReadLine();

            //3.Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Please enter a number:");
            string thirdNum = Console.ReadLine();
            double thirdTotal = Convert.ToDouble(thirdNum) / 12.5;
            Console.WriteLine("Your number / 12.5 = " + thirdTotal + "\nPress enter for the next math problem...");
            Console.ReadLine();

            //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.
            Console.WriteLine("Please enter a number:");
            string fourthNum = Console.ReadLine();
            bool TrueOrFalse = Convert.ToDouble(fourthNum) >= 50;
            Console.WriteLine("Is your number >= to 50? " + TrueOrFalse.ToString() + "\nPress enter for the next math problem...");
            Console.ReadLine();


            //5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).
            Console.WriteLine("Please enter a number:");
            string fifthNum = Console.ReadLine();
            int fifthTotal = Convert.ToInt32(fifthNum) % 7;
            Console.WriteLine(fifthTotal + " Is the remainder of " + fifthNum + " divided by 7! \nThis concludes our math problems. Hit enter to exit!");
            Console.ReadLine();


        }
    }
}
