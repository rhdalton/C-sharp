﻿using System;

namespace ClassesExample2
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
}