using System;

namespace GeneralExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Enter your age:");
                    int age = Convert.ToInt32(Console.ReadLine());

                    if (age < 1)
                    {
                        throw new OtherExceptions("Age can't be lower than 1.");
                    }
                    else
                    {
                        var dateNow = DateTime.Now;
                        var dateBorn = dateNow.AddYears(-age);
                        Console.WriteLine("You were born in {0}", dateBorn.Year);
                        validInput = true;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You did not enter a valid number with no decimals.");
                }
                catch (OtherExceptions ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadLine();
        }
    }

    class OtherExceptions : Exception
    {
        public OtherExceptions() : base() { }
        public OtherExceptions(string message) : base(message) { }
    }
}
