using System;
using System.Text;


namespace Strings_Assignment
{
    class Program
    {
        static void Main()
        {
            //Concatenate three strings
            string scoops = "two";
            string cone = "waffle";
            string flavor = "chocolate";
            Console.WriteLine("You have ordered " + scoops + " scoops of " + flavor + " ice cream on a " + cone + " cone!");
            Console.ReadLine();

            //Convert a string to uppercase.
            string name = "ashley marie";
            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();

            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder newString = new StringBuilder();
            newString.Append("Down they go!");
            newString.AppendLine();
            newString.Append("Hail and Snow!");
            newString.AppendLine();
            newString.Append("Freezes and Sneezes and Noses will blow!");
            newString.AppendLine();
            newString.Append("-Rohl Dahl");
            Console.WriteLine(newString);
            Console.ReadLine();


        }
    }
}
