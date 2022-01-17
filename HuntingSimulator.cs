using System;
using Test010_Inheritance.Birds;

namespace Test010_Inheritance.Hunting
{
    public class HuntingSimulator
    {
        public void Run(Bird bird, Hunter hunter)
        {
            bird.Fly();
            hunter.Shoot();
        }
    }
}