using Comp = DesignPatterns.Structural.Composite.CSharp.Implementation;
using Xunit;

namespace DesignPatterns.UnitTests.Structural.Composite
{
    public class CompositeUnitTests
    {
        [Fact]
        public void Execute_ReturnsDefaultImplementation_WhenCompositeContainsNoChildren()
        {
            // arrange
            Comp.IComponent component = new Comp.Composite();

            // act
            var result = component.Execute();

            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Execute_ReturnsDelegatedImplementation_WhenCompositeContainsChildren()
        {
            // arrange
            var rootComponent = new Comp.Composite();
            var subComponent = new Comp.Composite();

            var leaf1 = new Comp.Leaf();
            var leaf2 = new Comp.Leaf();

            rootComponent.Children.Add(subComponent);
            subComponent.Children.Add(leaf1);
            subComponent.Children.Add(leaf2);

            // act
            var result = rootComponent.Execute();

            // assert
            Assert.Equal(4, result);
        }
    }
}
