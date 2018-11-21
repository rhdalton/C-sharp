using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample3
{
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
}
