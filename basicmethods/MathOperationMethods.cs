using System;

namespace MathOperationClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());   
                
                int add = Operations.AddTen(num);
                Console.WriteLine(num + " + 10 = " + add);

                int mul = Operations.MultiplyTen(num);
                Console.WriteLine(num + " * 10 = " + mul);

                double div = Operations.DivideTen(num);
                Console.WriteLine(num + " / 10 = " + div);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("A whole number is required.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
