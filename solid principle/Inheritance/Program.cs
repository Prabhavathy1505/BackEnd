using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single Inheritance
            Mammal dog = new Mammal();
            dog.Eat();
            dog.Sleep();
            dog.GiveBirth();
            Console.WriteLine();
            //Multiple Inheritance(through interface)
            Dolphin dolphin = new Dolphin();
            dolphin.Eat();
            dolphin.Sleep();
            dolphin.Swim();
            Console.WriteLine();

            // Hierarchical Inheritance
            Bird sparrow = new Bird();
            sparrow.Eat();
            sparrow.Sleep();
            sparrow.Fly();
            Console.WriteLine();

            //Multilevel Inheritance
            Bat fruitBat = new Bat();
            fruitBat.Eat();
            fruitBat.Sleep();
            fruitBat.GiveBirth();
            fruitBat.Fly();

            Console.ReadLine();
        }
    }
}
