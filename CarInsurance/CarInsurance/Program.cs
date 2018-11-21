using System;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {

            bool valid_answer = false;
            string str_num;
            byte app_age = 0, app_tickets = 0;
            bool app_dui = false;

            Console.WriteLine("Car Insurance Application");

            while (valid_answer != true)
            {
                Console.WriteLine("What is your age?");
                str_num = Console.ReadLine();

                if (byte.TryParse(str_num, out app_age))
                {
                    valid_answer = true;
                }
                else
                {
                    ErrorMessage();
                }
            }

            valid_answer = false;
            while (valid_answer != true)
            {
                Console.WriteLine("Have your ever had a DUI? Y/N");
                str_num = Console.ReadLine().ToLower();

                if (str_num == "y")
                {
                    app_dui = true;
                    valid_answer = true;
                }
                else if (str_num == "n")
                {
                    app_dui = false;
                    valid_answer = true;
                }
                else
                {
                    ErrorMessage();
                }
            }

            valid_answer = false;
            while (valid_answer != true)
            {
                Console.WriteLine("How many speeding tickets do you have?");
                str_num = Console.ReadLine();

                if (byte.TryParse(str_num, out app_tickets))
                {
                    valid_answer = true;
                }
                else
                {
                    ErrorMessage();
                }
            }

            bool app_result = (app_age > 15 && app_dui == false && app_tickets < 4);
            Console.WriteLine("\nApplication qualification:");
            Console.WriteLine(app_result);

            Console.WriteLine("\nThat's the end of the program.");
            Console.ReadLine();
        }

        static void ErrorMessage()
        {
            Console.WriteLine("Invalid input, please try again.");
        }
    }
}