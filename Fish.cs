using System;

namespace Test010_Inheritance.Fishes
{
    public abstract class Fish
    {
        public abstract string GetName();

        public void Swim()
        {
            Console.WriteLine($"{GetName()} is swimming");
        }
    }
}