using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }

    public class Employee : Person
    {
        public int Id { get; set; }
    }
}