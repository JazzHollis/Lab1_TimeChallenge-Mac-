using System;

namespace Lab1_TimeChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Used to create DateTime object and assign values
            var FirstDate = new DateTime();
            var SecondDate = new DateTime();
            string repeat;



            do
            {
                Console.WriteLine("\n\n Date Comparison: Down to the years, months, days and minutes!\n");
                Console.Write("——————————————————————————————————————————————————————————————————————————\n");
                Console.WriteLine("Enter the first date: mm/dd/yyyy");


                //String ensures that the date is submitted correctly
                //If the submission is not equivalent to DateTime Console.WritLine message displays
                while (!DateTime.TryParse(Console.ReadLine(), out FirstDate))
                {
                    Console.WriteLine("Please enter correct date format");
                }

                Console.WriteLine("Enter the second date: mm/dd/yyyy");


                while (!DateTime.TryParse(Console.ReadLine(), out SecondDate))

                {
                    Console.WriteLine("Please enter correct date format");
                }

                //TimeSpan structure using DateTime method and assigning formula for time comparison
                TimeSpan diffTime = FirstDate.Subtract(SecondDate).Duration();

                Console.WriteLine("The difference between the two dates:");

                //Breaks down the time difference into years, months, days, hours and minutes
                Console.WriteLine(diffTime.TotalDays / 365.25 + " Years ");
                Console.WriteLine(diffTime.TotalDays / (365.25 / 12) + " Months");
                Console.WriteLine(diffTime.TotalDays + " Days");
                Console.WriteLine(diffTime.TotalHours + " Hours");
                Console.WriteLine(diffTime.TotalMinutes + " Minutes");

                Console.WriteLine("Would you like to select another date?(Y/N)");
                repeat = Console.ReadLine();



            }//Gives user the option to submit another date using do while loop
            while (repeat == "y" || repeat == "Y");

        }
    }
}  
