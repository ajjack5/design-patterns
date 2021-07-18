namespace DesignPatterns.Creational.Factory.CSharp.Examples.Generics
{
    public class Banana : IFruit
    {
        public string Name { get; private set; } = "Banana";
        public string Colour { get; private set; } = "Yellow";

        public void Rot()
        {
            Colour = "Black";
        }
    }
}
