﻿using Intuit.Ipp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace solid_principle(srp method)
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
*/

namespace solid_principle//OCP Method
{
    
    public interface IGenerateReport
    {
        public void generateReport();
    }
    public class HtmlReport : IGenerateReport
    {
        public void generateReport()
        {
            Console.WriteLine("Html Report");
        }
    }
    public class JsonReport : IGenerateReport
    {
        public void generateReport()
        {
            Console.WriteLine("Json Report");
        }
    }
    public class ExcelReport : IGenerateReport
    {
        public void generateReport()
        {
            Console.WriteLine("Excel Report");
        }
    }
    public class Employee
    {
        private ISendIntimation _IsendIntimation;
        public Employee(ISendIntimation iSendIntimation)
        {
            _IsendIntimation = iSendIntimation;
        }
        public void AddEmployee()
        {
            Console.WriteLine("\nEmployee Added in the database");
            _IsendIntimation.SendIntimation();
        }

    }
    }