using System;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string ans_course = Console.ReadLine();

            ushort ans_pagenumber;
            string pgnum = QuestionTwo();
            while(!ushort.TryParse(pgnum, out ans_pagenumber))
            {
                Console.WriteLine("Oops, not a valid response, try again.");
                pgnum = QuestionTwo();
            }

            bool ans_needhelp;
            string needhelp = QuestionThree();
            while (!bool.TryParse(needhelp, out ans_needhelp))
            {
                Console.WriteLine("Oops, not a valid response, answer 'True' or 'False'.");
                needhelp = QuestionThree();
            }

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string ans_positive = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string ans_feedback = Console.ReadLine();

            float ans_hours_studied;
            string hrsstudy = QuestionSix();
            while (!float.TryParse(hrsstudy, out ans_hours_studied))
            {
                Console.WriteLine("Oops, not a valid response, try again.");
                hrsstudy = QuestionSix();
            }

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }

        private static string QuestionTwo()
        {
            Console.WriteLine("What page number?");
            return Console.ReadLine();
        }
        private static string QuestionThree()
        {
            Console.WriteLine("Do you need help with anything? Answer True / False");
            return Console.ReadLine();
        }
        private static string QuestionSix()
        {
            Console.WriteLine("How many hours did you study today?");
            return Console.ReadLine();
        }
    }
}
