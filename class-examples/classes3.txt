using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 9 };

            employee.SayName();
            employee.GetEmployeeId();

            employee.Quit(employee);

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

    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Employee Info:");
            base.SayName();
        }

        public void GetEmployeeId()
        {
            Console.WriteLine("ID: {0}", Id);
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine("Employee: {0} {1} is quitting.", employee.FirstName, employee.LastName);
        }
    }

    interface IQuittable
    {
        void Quit(Employee employee);
    }
}