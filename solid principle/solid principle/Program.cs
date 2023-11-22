using System;
using static System.Net.Mime.MediaTypeNames;
/*using static solid_principle.Employee;
*/
namespace solid_principle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Employee employee = new Employee();*/
            /*employee.Employename = "Karthik kishore";
            employee.EmployeMobile = 987765123;
            employee.AddEmployee();
            Console.WriteLine($"Employee Name: {employee.Employename}");
            Console.WriteLine($"Employee Mobile: {employee.EmployeMobile}");
            Console.ReadLine();*/

            IGenerateReport _IGenerateReport = new HtmlReport();
            _IGenerateReport.generateReport();
            _IGenerateReport = new JsonReport();
            _IGenerateReport.generateReport();
            _IGenerateReport = new ExcelReport();
            _IGenerateReport.generateReport();

            IGenerateReport2 _IGenerateReport1 = new HtmlReport2();
            _IGenerateReport1.GenerateReport2();
            _IGenerateReport1 = new JsonReport2();
            _IGenerateReport1.GenerateReport2();
            _IGenerateReport1 = new ExcelReport2();
            _IGenerateReport1.GenerateReport2();

            /*Rectangle rectangle1 = new Rectangle { Height = 4, Width = 5 };
            Rectangle rectangle2 = new Rectangle { Height = 3, Width = 6 };

            Rectangle[] rectangles = { rectangle1, rectangle2 };
            AreaCalculator areaCalculator = new AreaCalculator();
            double totalArea = areaCalculator.TotalArea(rectangles);
            Console.WriteLine($"Total Area: {totalArea}");
            */
        }
    }
}
