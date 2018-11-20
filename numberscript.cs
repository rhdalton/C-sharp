using System;

namespace UsingNumbers
{
    class Program
    { 
        static void Main()
        {

            bool valid_answer = false;
            string str_num;
            int result_int;
            double result_double;

            while (valid_answer != true)
            {
                Console.WriteLine("Enter a whole number to multiply to 50:");
                str_num = Console.ReadLine();

                if (int.TryParse(str_num, out result_int))
                {
                    result_int = 50 * result_int;
                    Console.WriteLine(str_num + " multiplied by 50 is " + result_int);
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
                Console.WriteLine("\nEnter a number to add 25 to:");
                str_num = Console.ReadLine();

                if (double.TryParse(str_num, out result_double))
                {
                    result_double = 25 + result_double;
                    Console.WriteLine(str_num + " plus 25 is " + result_double);
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
                Console.WriteLine("\nEnter a number to divide by 12.5:");
                str_num = Console.ReadLine();

                if (double.TryParse(str_num, out result_double))
                {
                    result_double = result_double / 12.5;
                    Console.WriteLine(str_num + " divided by 12.5 is " + result_double);
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
                Console.WriteLine("\nEnter a number to compare to 50:");
                str_num = Console.ReadLine();

                if (double.TryParse(str_num, out result_double))
                {
                    if (result_double > 50)
                    {
                        Console.WriteLine("True, " + result_double + " is greater than 50");
                    }
                    else
                    {
                        Console.WriteLine("False, " + result_double + " is less than 50");
                    }
                        
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
                Console.WriteLine("\nEnter a number to find the remainder:");
                str_num = Console.ReadLine();

                if (double.TryParse(str_num, out result_double))
                {
                    result_double = result_double % 7;
                    Console.WriteLine(str_num + " divided by 7 has a remainder of " + result_double);
                    valid_answer = true;
                }
                else
                {
                    ErrorMessage();
                }
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