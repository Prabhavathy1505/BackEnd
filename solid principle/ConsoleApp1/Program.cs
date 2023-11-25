using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Tuple<int, string, bool> personTuple = new Tuple<int, string, bool>(1, "John Doe", true);
            Console.WriteLine($"ID: {personTuple.Item1}, Name: {personTuple.Item2}, IsAdult: {personTuple.Item3}");
            Console.WriteLine();

            //Returning a Tuple from a Method
            var result = GetPersonDetails(1);
            Console.WriteLine($"ID: {result.Item1}, Name: {result.Item2}, Age: {result.Item3}");
            Console.WriteLine();

            // Tuple Deconstruction
            var person = Tuple.Create(1, "Bob", 30);
            var (id, name, age) = person;
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
            Console.WriteLine();

            // Using ValueTuple (C# 7.0 and later)
            var anotherPerson = (1, "Jane Doe", false);
            Console.WriteLine($"ID: {anotherPerson.Item1}, Name: {anotherPerson.Item2}, IsAdult: {anotherPerson.Item3}");

            Console.ReadLine();
        }


        static Tuple<int, string, int> GetPersonDetails(int personId)
        {
            // Simulating fetching details from a database
            int id = personId;
            string name = "Alice";
            int age = 25;

            return Tuple.Create(id, name, age);
        }
    }
    }

