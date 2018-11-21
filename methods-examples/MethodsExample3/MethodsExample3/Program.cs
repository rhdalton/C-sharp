using System;

namespace MethodsExample3
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            int num1 = 0, num2 = 99, result = 0;

            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Enter the first number:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("An integer is required.");
                }
            }

            validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Enter the second number. You can skip this number by pressing enter without a value.");
                    string input = Console.ReadLine();
                    MathOperation op = new MathOperation();

                    if (input == "")
                    {
                        result = op.OperationOne(num1);
                    }
                    else
                    {
                        num2 = Convert.ToInt32(input);
                        result = op.OperationOne(num1, num2);
                    }
                    validInput = true;

                    Console.WriteLine("The answer to {0} * {1} is {2}", num1, num2, result);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("An integer is required.");
                }
            }
            Console.ReadLine();
        }
    }
}