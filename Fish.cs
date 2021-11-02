using System;

namespace Test010_Inheritance.Fishes
{
    public abstract class Fish
    {
        public string Name { get; set; }
        public Fish(string name)
        {
            Name = name;
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming");
        }
    }
}