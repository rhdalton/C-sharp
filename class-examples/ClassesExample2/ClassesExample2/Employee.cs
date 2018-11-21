using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample2
{
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
