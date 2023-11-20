using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle//LSP method
{
    /*public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }
*/
    /* public class AreaCalculator
     {
         public double TotalArea(Rectangle[] arrRectangles)
         {
             double totalArea = 0; 

             foreach (var objRectangle in arrRectangles)
             {
                 double area = objRectangle.Height * objRectangle.Width;
                 totalArea += area; 
             }

             return totalArea;
         }
     }*/
    
        public interface IGenerateReport1
        {
            public void GenerateReport();
        }
        public interface ItemplateFormat
        { 
        public void FetchTemplate();
       
        }
    public abstract class FormatedReport : IGenerateReport1, ItemplateFormat
    {
        public abstract void GenerateReport();
        public abstract void FetchTemplate();
    }
        public class HtmlReport1 : FormatedReport
        {
        public string Format {  get; set; }
        public override void FetchTemplate()
        {
            Format = "Html Report";
        }
        public override void GenerateReport()
            {
            Console.WriteLine(Format+ "Html Report");
            }
        }
        public class JsonReport1 : IGenerateReport1
    {
            public void GenerateReport()
            {
                Console.WriteLine("Json Report");
            }
        }
        public class ExcelReport1 : IGenerateReport1
    {
            public void GenerateReport()
            {
                Console.WriteLine("Excel Report");
            }
        }


    }




