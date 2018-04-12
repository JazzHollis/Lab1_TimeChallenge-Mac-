using System;

namespace Lab1_TimeChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Formats string used to convert to date
            var FirstDate = new DateTime();
            var SecondDate = new DateTime();
            string repeat;



            do
            {
                Console.WriteLine("\n\n Date Comparison: Down to the years, months, days and minutes!\n");
                Console.Write("——————————————————————————————————————————————————————————————————————————\n");
                Console.WriteLine("Enter the first date: mm/dd/yyyy");


                //To ensure proper date is submitted
                while (!DateTime.TryParse(Console.ReadLine(), out FirstDate))
                {
                    Console.WriteLine("Please enter correct date format");
                }

                Console.WriteLine("Enter the second date: mm/dd/yyyy");


                while (!DateTime.TryParse(Console.ReadLine(), out SecondDate))

                {
                    Console.WriteLine("Please enter correct date format");
                }

                //TimeSpan structure calculates time passed between the two submitted dates
                TimeSpan diffTime = FirstDate.Subtract(SecondDate).Duration();

                Console.WriteLine("The difference between the two dates:");

                //Breaks down the time difference into years, months, days, hours and minutes
                Console.WriteLine(diffTime.TotalDays / 365.25 + " years difference!");
                Console.WriteLine(diffTime.TotalDays / (365.25 / 12) + " months difference!");
                Console.WriteLine(diffTime.TotalDays + " days difference!");
                Console.WriteLine(diffTime.TotalHours + " hours difference!");
                Console.WriteLine(diffTime.TotalMinutes + " minutes difference!");

                Console.WriteLine("Would you like to select another date?(Y/N)");
                repeat = Console.ReadLine();


            //Gives user the option to submit another date using do while loop
            } while (repeat == "y" || repeat == "Y");
            

        }
    }
}
