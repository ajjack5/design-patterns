namespace DesignPatterns.Creational.Factory.CSharp.Examples.Generics
{
    public class Tomato : IFruit
    {
        public string Name { get; private set; } = "Tomato";
        public string Colour { get; private set; } = "Red";

        public void Rot()
        {
            Colour = "Chrimson";
        }
    }
}
