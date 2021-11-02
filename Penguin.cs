using System;
namespace Test010_Inheritance.Birds
{
    public class Penguin : Bird
    {
        public Penguin() : base("penguin")
            {
        
            }
        public override void Fly()
            {
            Console.WriteLine($"I'm penguin and i cannot fly");
            }
    }
}