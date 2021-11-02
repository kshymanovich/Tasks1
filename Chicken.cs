using System;

namespace Test010_Inheritance.Birds
{
    public class Chicken : Bird
    {
        public Chicken() : base("chicken")
        {
        }

        public override void Fly()
        {
            Console.WriteLine($"{_name} is flying");
            Console.WriteLine("but not far");    
        }
    }
}