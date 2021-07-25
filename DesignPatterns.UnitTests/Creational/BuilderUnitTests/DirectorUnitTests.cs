using DesignPatterns.Creational.Builder.CSharp.Implementation;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.BuilderUnitTests
{
    public class DirectorUnitTests
    {
        [Fact]
        public void BuildOption_BuildsOptionObject_WhenInvoked()
        {
            // arrange
            var director = new Director();

            // act
            var result = director.BuildOption();

            // assert
            Assert.NotNull(result);
        }

        [Fact]
        public void BuildOption_BuildsOptionObject_WithSpecificData()
        {
            // arrange
            var director = new Director();
            var expectedData = 542;

            // act
            var result = director.BuildOption();

            // assert
            Assert.Equal(expectedData, result.SpecificData);
        }

        [Fact]
        public void BuildOption_BuildsQuestionObject_WhenInvoked()
        {
            // arrange
            var director = new Director();

            // act
            var result = director.BuildQuestion();

            // assert
            Assert.NotNull(result);
        }

        [Fact]
        public void BuildOption_BuildsQuestionObject_WithSpecificData()
        {
            // arrange
            var director = new Director();
            var expectedData = 45;
            var otherExpectedData = 66;

            // act
            var result = director.BuildQuestion();

            // assert
            Assert.Equal(expectedData, result.SpecificData);
            Assert.Equal(otherExpectedData, result.OtherSpecificData);
        }
    }
}
