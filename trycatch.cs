using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        int[] numbers = { 35, 50, 100, 144, 300, 995, 1300 };
        Console.WriteLine("Enter a number to divide by:");
        try
        {
            int div = Convert.ToInt32(Console.ReadLine());
            foreach (int num in numbers)
            {
                double re = (double) num / div;
                Console.WriteLine(num + " divided by " + div + " is " + re);
            }

            Console.WriteLine("Done dividing numbers by " + div);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("A whole number is required.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Can't divide a number by zero.");
        }
        finally
        {
            Console.ReadLine();
        }
    }
}