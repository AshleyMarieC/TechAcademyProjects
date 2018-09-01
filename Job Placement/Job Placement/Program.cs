using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Placement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int odd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    odd += arr[i];
            }
            Console.WriteLine(odd);
            Console.ReadLine();


            long[] array = new long[] { 1158694135, 213587498713, 335116878613215 };
            long array2 = array.Sum();
            Console.WriteLine(array2);
            Console.ReadLine();

            Console.WriteLine(ReverseString.Reverse("Hello My Name is Ashley"));
            Console.ReadLine();


            string RemoveDuplicateChars(string key)
            {
                string result = "";
                foreach (char value in key)
                {
                    if (result.IndexOf(value) == -1)
                    {
                        result += value;
                    }
                }
                return result;
            }
            Console.WriteLine("Please Write a sentance");
            string sentance = Console.ReadLine();
            string value1 = RemoveDuplicateChars(sentance);
            Console.WriteLine(value1);
            Console.ReadLine();


            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }

        }
    }
}

