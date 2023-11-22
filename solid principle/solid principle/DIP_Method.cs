using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principle
{
    public class Intimation : ISendIntimation
    {
        public string ToMail { get; set; }
        public string Subject { get; set; }

        public void SendIntimation()
        {
            Console.WriteLine("Email sent Successfully");
        }

    }

    public interface ISendIntimation
    {
        public void SendIntimation();
    }

}
