namespace DesignPatterns.Creational.Factory.CSharp.Implementation
{
    public class ProductCreator : Factory
    {
        public override IProduct CreateProduct()
        {
            return new Product();
        }
    }
}
