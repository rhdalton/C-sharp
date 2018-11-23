using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validanswer = false;

            while (!validanswer)
            {
                try
                {
                    string dayOfWeekToday = DateTime.Today.DayOfWeek.ToString();
                    DaysofWeek currentDay = (DaysofWeek)Enum.Parse(typeof(DaysofWeek), dayOfWeekToday);

                    Console.WriteLine("Enter current day of week:");
                    string input = Console.ReadLine();

                    DaysofWeek inputDay = (DaysofWeek)Enum.Parse(typeof(DaysofWeek), input);

                    if (inputDay != currentDay)
                    {
                        Console.WriteLine("Incorrect, today is not " + inputDay);
                    }
                    else
                    {
                        Console.WriteLine("Correct, today is " + inputDay);
                    }
                    validanswer = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Please enter actual day of week");
                }
            }
            Console.ReadLine();
        }

        public enum DaysofWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}