namespace DesignPatterns.Creational.Factory.CSharp.Examples.Generics
{
    public class FruitFactory : IFruitFactory
    {
        // this type of Factory is a spin on the original GOF implementation, and delegates the switch logic into the factory itself
        // this can be turned into a traditional factory by extracting this logic to the request object
        public IFruit GetFruit<T>() where T : IFruit
        {
            if (typeof(T) == typeof(Apple))
            {
                return new Apple();
            }

            if (typeof(T) == typeof(Banana))
            {
                return new Banana();
            }

            if (typeof(T) == typeof(Tomato))
            {
                return new Tomato();
            }

            return null;
        }
    }
}
