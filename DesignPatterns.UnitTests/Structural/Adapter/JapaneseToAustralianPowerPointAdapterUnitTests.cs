using DesignPatterns.Structural.Adapter.CSharp.Examples.NonStatic;
using Xunit;

namespace DesignPatterns.UnitTests.Structural.Adapter
{
    public class JapaneseToAustralianPowerPointAdapterUnitTests
    {
        [Fact]
        public void AcceptPlug_ReturnsTrue_WhenAustralianPowerPlugProvided()
        {
            // arrange
            var australianPowerPoint = new AustralianPowerPoint();
            AustralianPowerPlug powerPlug = new AustralianPowerPlug();

            // act
            var result = australianPowerPoint.AcceptAustralianPlug(powerPlug);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void AcceptPlug_ReturnsTrue_WhenJapanesePowerPlugProvidedIntoAdapter()
        {
            // arrange
            var powerPointAdapter = new JapaneseToAustralianPowerPointAdapter(new PowerConverter());
            JapanesePowerPlug japanesePowerPlug = new JapanesePowerPlug();

            // act
            var result = powerPointAdapter.AcceptJapanesePlug(japanesePowerPlug);

            // assert
            Assert.True(result);
        }
    }
}
