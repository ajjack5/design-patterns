namespace DesignPatterns.Creational.AbstractFactory.CSharp.Implementation
{
    public class Factory1 : IAbstractFactory
    {
        public ProductA CreateProductA()
        {
            return new Factory1ProductA { Property = "unique Factory1ProductA property" };
        }

        public ProductB CreateProductB()
        {
            return new Factory1ProductB { Property = "unique Factory1ProductB property" };
        }
    }
}
