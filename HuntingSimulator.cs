using Test010_Inheritance.Birds;

namespace Test010_Inheritance.Hunting
{
    public class HuntingSimulator
    {
        public void Run(Chicken chicken, Hunter hunter)
        {
            chicken.Fly();
            hunter.Shoot();
        }
    }
}