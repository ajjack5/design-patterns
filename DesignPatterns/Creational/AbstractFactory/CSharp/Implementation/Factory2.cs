namespace DesignPatterns.Creational.AbstractFactory.CSharp.Implementation
{
    public class Factory2 : IAbstractFactory
    {
        public ProductA CreateProductA()
        {
            return new Factory2ProductA { Property = "unique Factory2ProductA property" };
        }

        public ProductB CreateProductB()
        {
            return new Factory2ProductB { Property = "unique Factory2ProductB property" };
        }
    }
}
