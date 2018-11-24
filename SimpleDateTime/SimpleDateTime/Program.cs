using System;

namespace SimpleDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Right now it is {0}", now);
            Console.WriteLine("Enter a number:");
            try
            {
                double num = Convert.ToDouble(Console.ReadLine());                
                Console.WriteLine("The time {0} hours from now: {1}", num, now.AddHours(num));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Need to enter valid number.");
            }

            Console.ReadLine();            
        }
    }
}
