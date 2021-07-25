namespace DesignPatterns.Creational.AbstractFactory.CSharp.Examples.Generics
{
    public class NewFurnitureFactory : IFurnitureFactory<NewFurnitureFactory> // reference itself as generic for DI implementation.   No need for this if not using DI container
    {
        public Chair CreateChair()
        {
            return new NewChair();
        }

        public Table CreateTable()
        {
            return new NewTable();
        }
    }
}
