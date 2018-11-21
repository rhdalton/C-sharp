using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 9 };

            employee.SayName();
            employee.EmployeeId();

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

        public void EmployeeId()
        {
            Console.WriteLine("ID: {0}", Id);
        }
    }
}
