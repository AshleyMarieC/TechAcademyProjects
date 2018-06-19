using System;
using System.Collections.Generic;


namespace Arrays_and_Strings
{
    class Program
    {
        static void Main()
        {
            //1.Create a one-dimensional Array of strings.
            //Ask the user to select an index of the Array and then display the string at that index on the screen.

            string[] stringArray = { "Clubs", "Spades", "Hearts", "Diamonds" };
            foreach (var item in stringArray)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\nPlease Select an index (0-3) of the Array: ");
            int selectIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked: " + stringArray[selectIndex]);
            Console.ReadLine();


            //2.Create a one-dimensional Array of integers.
            //Ask the user to select an index of the Array and then display the integer at that index on the screen.
            //3.Add in a message that displays when the user selects an index that doesn’t exist.

            int[] intArray = { 5, 60, 12, 500, 1000, 5000, 3, 50};
            Console.WriteLine("Please Select a number between 1 and 7 to see how much you have won: ");
            int select = Convert.ToInt32(Console.ReadLine());
            if (select > 7)
            {
                Console.WriteLine("I'm sorry that index does not exist");
                Console.ReadLine();
            }
            if (select < 0)
            {
                Console.WriteLine("I'm sorry that index does not exist");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You won: " + intArray[select] + " dollars, CONGRATS!!");
                Console.ReadLine();
            }
            


            //4.Create a List of strings. 
            //Ask the user to select an index of the List and then display the content at that index on the screen.

            List<string> stringList = new List<string>();
            stringList.Add("Queen");
            stringList.Add("King");
            stringList.Add("Jack");
            stringList.Add("Ace");
            Console.WriteLine("Select an index (0-3) of the Array to see which card you have drawn: ");
            int list = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked a: " + stringList[list] + " of " + stringArray[selectIndex]);
            Console.ReadLine();

        }
    }
}
