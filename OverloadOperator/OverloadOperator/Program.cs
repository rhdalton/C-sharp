using System;
using System.Collections.Generic;

namespace OverloadOperator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "John", LastName = "Smith", Id = 10 };
            Employee employee2 = new Employee() { FirstName = "Bob", LastName = "Smith", Id = 10 };

            if (employee1 == employee2)
            {
                Console.WriteLine("This is the same person.");
            }
            else
            {
                Console.WriteLine("This is not the same person.");
            } 
            Console.ReadLine();
        }
    }
}