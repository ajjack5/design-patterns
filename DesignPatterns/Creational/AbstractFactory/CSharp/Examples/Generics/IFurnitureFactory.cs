namespace DesignPatterns.Creational.AbstractFactory.CSharp.Examples.Generics
{
    public interface IFurnitureFactory<T> where T : class
    {
        Chair CreateChair();
        Table CreateTable();
    }
}
