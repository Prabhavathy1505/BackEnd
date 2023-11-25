using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class InheritanceClass
    {
    }


        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating.");
            }

            public void Sleep()
            {
                Console.WriteLine("Animal is sleeping.");
            }
        }

        // Example 1: Single Inheritance
        class Mammal : Animal
        {
            public void GiveBirth()
            {
                Console.WriteLine("Mammal gives birth.");
            }
        }

        // Example 2: Multiple Inheritance (through interface)
        interface ISwim
        {
            void Swim();
        }

        class Dolphin : Animal, ISwim
        {
            public void Swim()
            {
                Console.WriteLine("Dolphin is swimming.");
            }
        }

        // Example 3: Hierarchical Inheritance
        class Bird : Animal
        {
            public void Fly()
            {
                Console.WriteLine("Bird is flying.");
            }
        }

        // Example 4: Multilevel Inheritance
        class Bat : Mammal
        {
            public void Fly()
            {
                Console.WriteLine("Bat is flying.");
            }
        }
    }

