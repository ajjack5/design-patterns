using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite.CSharp.Implementation
{
    public class Composite : Component
    {
        public IList<Component> Children { get; set; } = new List<Component>();

        // structure the execution by passing it down to anything below it
        public override int Execute()
        {
            if (Children == null || Children?.Count == 0)
            {
                return 1;
            }

            int result = 1;

            foreach (var child in Children)
            {
                result += child.Execute();
            }

            return result;
        }
    }
}
