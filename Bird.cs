using System;

namespace Test010_Inheritance.Birds
{
    public abstract class Bird
    {
        private readonly string _name;

        protected Bird(string name)
        {
            _name = name;
        }

        public void Fly()
        {
            Console.WriteLine($"{_name} is flying");            
        }
    }
}