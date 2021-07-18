namespace DesignPatterns.Creational.Factory.CSharp.Examples.Generics
{
    public interface IFruitFactory
    {
        public IFruit GetFruit<T>() where T : IFruit;
    }
}
