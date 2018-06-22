using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a one-dimensional Array of strings.

            string[] namesArray = { "Jim", "Pam", "Dwight" };
            Console.WriteLine("WELCOME TO MAD LIBS");
            //Ask the user to input some text.
            Console.WriteLine("\nPlease select an adjective:  ");
            string myAdjective = Console.ReadLine();
            Console.WriteLine("Please select another adjective:  ");
            string myAdjective2 = Console.ReadLine();
            Console.WriteLine("Please select one more adjective:  ");
            string myAdjective3 = Console.ReadLine();
            //Create a loop that goes through each string in the Array, adding the user’s text to the string.
            foreach (string name in namesArray)
            {
                if (name == "Jim")
                {
                    Console.WriteLine(namesArray[0] + " is " + myAdjective);
                }
                if (name == "Pam")
                {
                    Console.WriteLine(namesArray[1] + " is " + myAdjective2);
                }
                if (name == "Dwight")
                {
                    Console.WriteLine(namesArray[2] + " is " + myAdjective3);
                }

            }
            Console.ReadLine();
            //Then create a loop that prints off each string in the Array on a separate line.
            foreach (var item in namesArray)
            {
                Console.WriteLine(item.ToString());

            }
            Console.ReadLine();


            //2.Create an infinite loop.
            //for (int i = 0; i < 1; i++, i--)
           // {
             //   Console.WriteLine("Infinite Loop");
             //   Console.ReadLine();
           // }

            //3.Fix the infinite loop so it will execute.

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Infinite Loop");
                Console.ReadLine();
            }

            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            List<int> numbers = new List<int>();
            numbers.Add(45);
            numbers.Add(10);
            numbers.Add(60);
            numbers.Add(85);

            foreach (int number in numbers)
            {
                if (number < 50)
                {
                    Console.WriteLine("Numbers less than 50: " + number);
                    
                }
            }
            Console.ReadLine();


            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

            List<int> numbers2 = new List<int>();
            numbers2.Add(45);
            numbers2.Add(10);
            numbers2.Add(60);
            numbers2.Add(85);
            numbers2.Add(43);
            numbers2.Add(95);
            numbers2.Add(6);

            foreach (int number2 in numbers2)
            {
                if (number2 <= 45)
                {
                    Console.WriteLine("Numbers less than or equal to 45: " + number2);
                    
                }
            }
            Console.ReadLine();


            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to
            //search for in the List.Create a loop that iterates through the loop and then displays the
            //index of the array that contains matching text on the screen.
            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //8.Add code to that above loop that stops it from executing once a match has been found.

            List<string> nameList = new List<string>();
            nameList.Add("Cersei");
            nameList.Add("Tyrion");
            nameList.Add("Arya");
            nameList.Add("Sansa");
            nameList.Add("Daenerys");

            Console.WriteLine("What is the first name of your favorite Game of Thrones Character?");
            string letter = Console.ReadLine();

            foreach (string name in nameList)
            {
                if (letter == "Cersei")
                {
                    Console.WriteLine("Really," + letter + "is your favorite?");
                    break;
                }
                if (letter == "Tyrion")
                {
                    Console.WriteLine(letter + ", He's my favorite too!");
                    break;
                }
                if (letter == "Arya")
                {
                    Console.WriteLine("I like " + letter + ", isn't she great!");
                    break;
                }
                if (letter == "Sansa")
                {
                    Console.WriteLine(letter + " has grown on me");
                    break;
                }
                if (letter == "Daenerys")
                {
                    Console.WriteLine("Ooo," +letter+" good choice!!");
                    break;
                }
                else
                {
                    Console.WriteLine("No," +letter+" can't be your favorite!");
                    break;
                }


            }
            Console.ReadLine();

            //9.Create a List of strings that has at least two identical strings in the List. 
            //Ask the user to select text to search for in the List.Create a loop that iterates through the loop and then displays 
            //the indices of the array that contain matching text on the screen.
            //10..Add code to that above loop that tells a user if they put in text that isn’t in the List.

            List<string> animals = new List<string>();
            animals.Add("Sheep");
            animals.Add("Goat");
            animals.Add("Horse");
            animals.Add("Chicken");
            animals.Add("Horse");
            animals.Add("Pig");

            Console.WriteLine();
            foreach (string farm in animals)
            {
                Console.WriteLine(farm);
            }

            Console.WriteLine("\nPick an animal from the above list");
            string animal = Console.ReadLine();

            if (animal == "Sheep")
            {
                Console.WriteLine("\nIndex Of " + animal + ": {0}",
                animals.IndexOf(animal));
            }
            if (animal == "Goat")
            {
                Console.WriteLine("\nIndex Of " + animal + ": {0}",
                animals.IndexOf(animal));
            }
            if (animal == "Chicken")
            {
                Console.WriteLine("\nIndex Of " + animal + ": {0}",
                animals.IndexOf(animal));
            }
            if (animal == "Pig")
            {
                Console.WriteLine("\nIndex Of " + animal + ": {0}",
                animals.IndexOf(animal));
            }
            if (animal == "Horse")
            {
                Console.WriteLine("\nIndex Of " + animal + ": {0}",
               animals.IndexOf(animal));
                Console.WriteLine("\nIndex Of " + animal + ": {0}",
                animals.IndexOf(animal, 3));
            }
            else {
                Console.WriteLine("I'm sorry, that animal is not on the list");
            }

            Console.ReadLine();

            //11.Create a List of strings that has at least two identical strings in the List. 
            //Create a foreach loop that evaluates each item in the list, and displays a message showing the   
            //string and whether or not it has already appeared in the list.

            List<int> randomNum = new List<int>();
            randomNum.Add(5);
            randomNum.Add(10);
            randomNum.Add(15);
            randomNum.Add(10);
            randomNum.Add(12);
            randomNum.Add(9);
            randomNum.Add(50);
            randomNum.Add(18);
            randomNum.Add(18);
            randomNum.Add(25);

            foreach (int value in randomNum)
            {
                Console.WriteLine(value);
            }

            List<int> distinct = randomNum.Distinct().ToList();

            foreach (int value in distinct)
            {
                Console.WriteLine("\nDistinct values of above list: {0}", value);
            }
            Console.ReadLine();
        }
    }
}
