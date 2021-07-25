namespace DesignPatterns.Creational.AbstractFactory.CSharp.Examples.Generics
{
    public class OldFurnitureFactory : IFurnitureFactory<OldFurnitureFactory> // reference itself as generic for DI implementation.   No need for this if not using DI container
    {
        public Chair CreateChair()
        {
            return new OldChair();
        }

        public Table CreateTable()
        {
            return new OldTable();
        }
    }
}
