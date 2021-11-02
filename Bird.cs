using System;

namespace Test010_Inheritance.Birds
{
    public class Bird
    {
        public readonly string _name;

        public Bird(string name)
        {
            _name = name;
        }

        public virtual void Fly()
        {
            Console.WriteLine($"{_name} is flying");            
        }

    }
}