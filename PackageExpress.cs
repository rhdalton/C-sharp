using System;

namespace PackageExpress
{
    class Program
    { 
        static void Main()
        {

            bool valid_answer = false, end_app = false;
            string str_num;
            byte pkg_weight = 0, pkg_width = 0, pkg_height = 0, pkg_length = 0;
            decimal pkg_cost = 0;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            while (valid_answer != true)
            {
                Console.WriteLine("Enter the package weight:");
                str_num = Console.ReadLine();

                if (byte.TryParse(str_num, out pkg_weight))
                {
                    valid_answer = true;
                    if(pkg_weight > 50)
                    {
                        Console.WriteLine("Package too big to be shipped via Package Express.");
                        end_app = true;
                    }
                }
                else
                {
                    ErrorMessage();
                }                
            }

            valid_answer = false;
            while (valid_answer != true && end_app == false)
            {
                Console.WriteLine("Enter package width:");
                str_num = Console.ReadLine();

                if (byte.TryParse(str_num, out pkg_width))
                {
                    valid_answer = true;
                }
                else
                {
                    ErrorMessage();
                }
            }

            valid_answer = false;
            while (valid_answer != true && end_app == false)
            {
                Console.WriteLine("Enter package height:");
                str_num = Console.ReadLine();

                if (byte.TryParse(str_num, out pkg_height))
                {
                    valid_answer = true;
                }
                else
                {
                    ErrorMessage();
                }
            }

            valid_answer = false;
            while (valid_answer != true && end_app == false)
            {
                Console.WriteLine("Enter package length:");
                str_num = Console.ReadLine();

                if (byte.TryParse(str_num, out pkg_length))
                {
                    valid_answer = true;
                }
                else
                {
                    ErrorMessage();
                }
            }

            if(pkg_width + pkg_height + pkg_length > 50 && end_app == false)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
            else if(end_app == false)
            {
                pkg_cost = (decimal) (pkg_width + pkg_height + pkg_length) * pkg_weight / 100;
                pkg_cost = Math.Round(pkg_cost, 2);
                Console.WriteLine("Your estimated total for shipping this package is: $" + string.Format("{0:0.00}", pkg_cost));
                Console.WriteLine("Thank you.");
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
