namespace DesignPatterns.Creational.AbstractFactory.CSharp.Examples.Generics
{
    public class NewChair : Chair
    {
        public NewChair()
        {
            FurnitureStyle = FurnitureStyle.New;
            Legs = 4;
        }
    }
}
