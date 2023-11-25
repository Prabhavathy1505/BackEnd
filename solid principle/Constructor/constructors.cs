using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class constructors
    {


            public class Person
            {
                // Default Constructor
                public Person()
                {
                    Console.WriteLine("Default Constructor called");
                }

                public string Name { get; set; }
                public int Age { get; set; }
            }

        }
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            // Parameterized Constructor
            public Point(int x, int y)
            {
                X = x;
                Y = y;
                Console.WriteLine($"Parameterized Constructor called with coordinates ({x}, {y})");
            }
        }

        public class Logger
        {
            // Static Constructor
            static Logger()
            {
                Console.WriteLine("Static Constructor called once, when the class is first used.");
            }

            public static void LogMessage(string message)
            {
                Console.WriteLine(message);
            }
        }

    }

