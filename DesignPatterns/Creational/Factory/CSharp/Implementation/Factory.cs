namespace DesignPatterns.Creational.Factory.CSharp.Implementation
{
    public class Factory
    {
        public virtual bool CheckProductData()
        {
            IProduct product = CreateProduct();
            return product.Data == "Product";
        }

        public virtual IProduct CreateProduct()
        {
            return null;
        }
    }
}
