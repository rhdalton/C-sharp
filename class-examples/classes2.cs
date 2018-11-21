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

    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }

    public class Employee : Person
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Employee Info:");
            base.SayName();
        }

        public void EmployeeId()
        {
            Console.WriteLine("ID: {0}", Id);
        }
    }
}
