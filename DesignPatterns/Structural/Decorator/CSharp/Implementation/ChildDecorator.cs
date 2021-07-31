namespace DesignPatterns.Structural.Decorator.CSharp.Implementation
{
    public class ChildDecorator : BaseDecorator
    {
        public ChildDecorator(IComponent component) : base(component) { }

        // wrap original implementation
        public new string Execute()
        {
            return "[[child decorated]]" + base.Execute();
        }
    }
}
