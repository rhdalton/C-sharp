using System;

namespace ClassesExample3
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
}