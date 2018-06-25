using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
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
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you!");
                Console.ReadLine();
            }
            
            
        }
    }
}
