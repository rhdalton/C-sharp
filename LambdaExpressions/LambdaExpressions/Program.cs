using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        public List<Employee> Employees { get; set; }

        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            string[] firstNames = new string[] { "John", "Bob", "Joe", "Sarah", "Mark", "Joe", "David", "Jane", "Jill", "Chris" };
            string[] lastNames = new string[] { "Waters", "Smith", "Jones", "Mills", "Watts", "Stone", "Reed", "Barr", "Morton", "Payne" };

            for (int i = 0; i < firstNames.Length; i++)
            {
                Employee employee = new Employee() { FirstName = firstNames[i], LastName = lastNames[i], Id = i+1 };
                Employees.Add(employee);
            }

            /* get and show all employees where first name Joe */
            List<Employee> nameJoe = new List<Employee>();

            foreach(Employee employee in Employees)
            {
                if(employee.FirstName == "Joe")
                {
                    nameJoe.Add(employee);
                }
            }
                        
            foreach(Employee employee in nameJoe)
            {
                Console.WriteLine("Name: {0} {1} Id: {2}", employee.FirstName, employee.LastName, employee.Id);
            }

            /* get Joe employees with Lambda function */
            List<Employee> nameJoeLambda = Employees.Where(x => x.FirstName == "Joe").ToList();


            /* show all employees who have Ids greater than 5 */
            List<Employee> EmployeeIds = Employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("\nEmployees with Ids greater than 5:");
            foreach (Employee employee in EmployeeIds)
            {
                Console.WriteLine("Name: {0} {1} Id: {2}", employee.FirstName, employee.LastName, employee.Id);
            }
            Console.ReadLine();           
        }
    }
}
