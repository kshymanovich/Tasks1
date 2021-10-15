using System;

namespace Test010_Inheritance.Birds
{
    public class Chicken : Bird
    {
        public Chicken() : base("chicken")
        {
        }

        public void Fly()
        {
            Console.WriteLine("but not far");    
        }
    }
}