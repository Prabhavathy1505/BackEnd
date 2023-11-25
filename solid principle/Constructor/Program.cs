using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
           
          
            constructors.Person person = new constructors.Person();
            Console.WriteLine();

            // Parameterized Constructor
            Point point = new Point(10, 20);
            Console.WriteLine();

            Logger.LogMessage("Logging a message using the static constructor");
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
