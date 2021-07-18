namespace DesignPatterns.Creational.Factory.CSharp.Examples.Generics
{
    public class Apple : IFruit
    {
        public string Name { get; private set; } = "Apple";
        public string Colour { get; private set; } = "Red";

        public void Rot()
        {
            Colour = "Brown";
        }
    }
}
