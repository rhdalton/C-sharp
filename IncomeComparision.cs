using System;

namespace IncomeComparison
{
    class Program
    { 
        static void Main()
        {

            bool valid_answer = false;
            string str_num;
            byte hours_worked = 0;
            float hourly_rate = 0.00f;
            float result_salary_1, result_salary_2;

            Console.WriteLine("Anonymous Income Comparision Program");
            Console.WriteLine("Person 1:");

            while (valid_answer != true)
            {
                Console.WriteLine("Enter hourly rate:");
                str_num = Console.ReadLine();

                if (float.TryParse(str_num, out hourly_rate))
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
                Console.WriteLine("Enter hours worked per week:");
                str_num = Console.ReadLine();

                if (byte.TryParse(str_num, out hours_worked))
                {
                    valid_answer = true;
                }
                else
                {
                    ErrorMessage();
                }
            }

            result_salary_1 = hourly_rate * hours_worked;

            Console.WriteLine("\nPerson 2:");

            valid_answer = false;
            while (valid_answer != true)
            {
                Console.WriteLine("Enter hourly rate:");
                str_num = Console.ReadLine();

                if (float.TryParse(str_num, out hourly_rate))
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
                Console.WriteLine("Enter hours worked per week:");
                str_num = Console.ReadLine();

                if (byte.TryParse(str_num, out hours_worked))
                {
                    valid_answer = true;
                }
                else
                {
                    ErrorMessage();
                }
            }

            result_salary_2 = hourly_rate * hours_worked;

            Console.WriteLine("\nWeekly salary of Person 1:");
            Console.WriteLine(result_salary_1);
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine(result_salary_2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if (result_salary_1 > result_salary_2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


            Console.WriteLine("\nThat's the end of the program.");
            Console.ReadLine();
        }

        static void ErrorMessage()
        {
            Console.WriteLine("Invalid input, please try again.");
        }
    }
}
