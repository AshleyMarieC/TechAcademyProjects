using System;


namespace Package_Express_Branching_Excercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below \nPlease enter your package weight:");
            double enterWeight = Convert.ToDouble(Console.ReadLine());
            if (enterWeight > 50)
            {
                Console.WriteLine("ERROR: Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                double length = Convert.ToDouble(Console.ReadLine());
               

                if (width + height + length > 50)
                {
                 Console.WriteLine("ERROR: Package too big to be shipped via Package Express.");
                 Console.ReadLine();
                }
                else
                {
                    double total = (width + height + length) * enterWeight / 100;
                    string quote = string.Format("{0:c}", Convert.ToDecimal(total));
                    Console.WriteLine("Your estimated total for shipping this package is:"+quote);
                    Console.ReadLine();
                }

            }
        }
    }
}
