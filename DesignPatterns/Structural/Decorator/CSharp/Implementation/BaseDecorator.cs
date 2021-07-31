namespace DesignPatterns.Structural.Decorator.CSharp.Implementation
{
    public abstract class BaseDecorator : IComponent
    {
        protected IComponent Wrapper { get; private set; }

        protected BaseDecorator(IComponent component)
        {
            Wrapper = component;
        }

        public string Execute()
        {
            if (Wrapper == null)
            {
                return null;
            }

            return Wrapper.Execute();
        }
    }
}
