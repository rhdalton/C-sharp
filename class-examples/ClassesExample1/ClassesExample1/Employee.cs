using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample1
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public void EmployeeId()
        {
            Console.WriteLine("ID: {0}", Id);
        }
    }
}
