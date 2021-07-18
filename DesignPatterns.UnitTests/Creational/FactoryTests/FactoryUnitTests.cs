using DesignPatterns.Creational.Factory.CSharp.Implementation;
using System;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.FactoryTests
{
    public class FactoryUnitTests
    {
        [Fact]
        public void CreateProduct_ReturnsNull_WhenNoFactoryImplementationProvided()
        {
            // arrange
            Factory factory = new Factory();

            // act
            var result = factory.CreateProduct();

            // assert
            Assert.Null(result);
        }

        [Fact]
        public void CheckProductLogic_ThrowsNullReferenceException_WhenNoFactoryImplementationProvided()
        {
            // arrange
            Factory factory = new Factory();

            // act
            Func<bool> result = () => factory.CheckProductData();

            // assert
            Assert.Throws<NullReferenceException>(() => result.Invoke());
        }

        [Fact]
        public void CreateProduct_ReturnsProduct_WhenFactoryImplementationProvided()
        {
            // arrange
            Factory factory = new ProductCreator();

            // act
            var result = factory.CreateProduct();

            // assert
            Assert.NotNull(result);
        }

        [Fact]
        public void CheckProductLogic_ReturnsTrue_WhenFactoryImplementationProvided()
        {
            // arrange
            Factory factory = new ProductCreator();

            // act
            var result = factory.CheckProductData();

            // assert
            Assert.True(result);
        }
    }
}
