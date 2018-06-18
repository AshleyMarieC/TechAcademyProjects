using System;

namespace DailyReportDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report\n");

            Console.WriteLine("What course are you on?");
            string courseNum = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNum;
            pageNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool needHelp;
            needHelp = bool.Parse(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string Feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            double hoursStudied;
            hoursStudied = double.Parse(Console.ReadLine());

            Console.WriteLine("“Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” ");
            Console.ReadLine();
        }
    }
}
