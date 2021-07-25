namespace DesignPatterns.Creational.AbstractFactory.CSharp.Examples.Generics
{
    public class OldChair : Chair
    {
        public OldChair()
        {
            FurnitureStyle = FurnitureStyle.Old;
            Legs = 5;
        }
    }
}
