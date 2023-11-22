using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle
{
   public interface IGenerateReport2
        {
            public void GenerateReport2();
        }
        public interface ItemplateFormat
        {
            public void FetchTemplate();

        }
        public abstract class FormatedReport : IGenerateReport2, ItemplateFormat
        {
            public abstract void GenerateReport2();
            public abstract void FetchTemplate();
        }
        public class HtmlReport2 : FormatedReport
        {
            public string Format { get; set; }
            public override void FetchTemplate()
            {
                Format = "Html Report";
            }
            public override void GenerateReport2()
            {
                Console.WriteLine(Format + "Html Report");
            }
        }
        public class JsonReport2 : IGenerateReport2
        {
            public void GenerateReport2()
            {
                Console.WriteLine("Json Report");
            }
        }
        public class ExcelReport2 : IGenerateReport2
        {
            public void GenerateReport2()
            {
                Console.WriteLine("Excel Report");
            }
        }


    }





