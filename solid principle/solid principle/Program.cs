using System;

namespace solid_principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Employename = "Karthik kishore";
            employee.EmployeMobile = 987765123;
            employee.AddEmployee();
            Console.WriteLine($"Employee Name: {employee.Employename}");
            Console.WriteLine($"Employee Mobile: {employee.EmployeMobile}");
            Console.ReadLine();
        }
    }
}
