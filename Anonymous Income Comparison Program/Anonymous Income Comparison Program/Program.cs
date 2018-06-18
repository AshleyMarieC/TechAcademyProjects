using System;


namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person One \nHourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hour Worked?");
            string hoursWorked1 = Console.ReadLine();
            Console.WriteLine("Person Two \nHourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hour Worked?");
            string hoursWorked2 = Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1:");
            double total1 = Convert.ToDouble(hourlyRate1) * Convert.ToDouble(hoursWorked1);
            Console.WriteLine(total1);

            Console.WriteLine("Annual salary of Person 2:");
            double total2 = Convert.ToDouble(hourlyRate2) * Convert.ToDouble(hoursWorked2);
            Console.WriteLine(total2);
            

            Console.WriteLine("Does Person 1 make more money than Person 2");
            bool TrueOrFalse = Convert.ToDouble(total1) > Convert.ToDouble(total2);
            Console.WriteLine(TrueOrFalse.ToString());
            Console.ReadLine();

        }
    }
}
