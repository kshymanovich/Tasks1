using Test010_Inheritance.Birds;

namespace Test010_Inheritance.Owls
{
    public abstract class Owl : Bird
    {
        public Owl(string type) : base($"{type} owl")
        {
        }
    }
}
