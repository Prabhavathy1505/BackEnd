using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle
{
    //srp method
     public class Employee
    {

        public string Employename { get; set; }

        public int EmployeMobile { get; set; }

        public void AddEmployee()
        {
            Console.WriteLine("Employee Added");
        }

    }
}
