using System;
using System.Collections.Generic;


namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.things = new List<string>() { "A", "B", "C", "D", "E" };

            Employee<int> employee2 = new Employee<int>();
            employee2.things = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (string t in employee1.things)
            {
                Console.WriteLine(t);
            }
            foreach (int t in employee2.things)
            {
                Console.WriteLine(t);
            }



            //Employee employee1 = new Employee() { FirstName = "John", LastName = "Smith", Id = 10 };
            //Employee employee2 = new Employee() { FirstName = "Bob", LastName = "Smith", Id = 10 };

            //if (employee1 == employee2)
            //{
            //    Console.WriteLine("This is the same person.");
            //}
            //else
            //{
            //    Console.WriteLine("This is not the same person.");
            //} 
            Console.ReadLine();
        }
    }
}