using System;

namespace MethodsExample4
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool valid_input = false;

            while (!valid_input)
            {
                try
                {
                    Console.WriteLine("Enter a number:");
                    int num = Convert.ToInt32(Console.ReadLine());

                    MathOperations op = new MathOperations();
                    op.DivideByTwo(num, out int result_num);
                    Console.WriteLine("{0} divided by 2 is {1}", num, result_num);
                    valid_input = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a whole number.");
                }
            }

            Console.ReadLine();
        }
    }    
}