using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 23;
            object obj = num;
            int i = (int)obj;
            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);

        }
    }
}
