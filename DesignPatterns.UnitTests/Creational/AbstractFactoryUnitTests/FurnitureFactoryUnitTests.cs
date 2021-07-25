using DesignPatterns.Creational.AbstractFactory.CSharp.Examples.Generics;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.AbstractFactoryUnitTests
{
    public class FurnitureFactoryUnitTests
    {
        [Fact]
        public void CreateChair_ReturnsOldFactoryCreatedChair_WhenOldFactoryImplementationUsed()
        {
            // arrange
            IFurnitureFactory<OldFurnitureFactory> factory = new OldFurnitureFactory();

            // act
            var result = factory.CreateChair();

            // assert
            Assert.IsAssignableFrom<Chair>(result);
            Assert.IsType<OldChair>(result);

            Assert.Equal(FurnitureStyle.Old, result.FurnitureStyle);
            Assert.Equal(5, result.Legs);
        }

        [Fact]
        public void CreateChair_ReturnsNewFactoryCreatedChair_WhenNewFactoryImplementationUsed()
        {
            // arrange
            IFurnitureFactory<NewFurnitureFactory> factory = new NewFurnitureFactory();

            // act
            var result = factory.CreateChair();

            // assert
            Assert.IsAssignableFrom<Chair>(result);
            Assert.IsType<NewChair>(result);

            Assert.Equal(FurnitureStyle.New, result.FurnitureStyle);
            Assert.Equal(4, result.Legs);
        }

        [Fact]
        public void CreateTable_ReturnsOldFactoryCreatedTable_WhenOldFactoryImplementationUsed()
        {
            // arrange
            IFurnitureFactory<OldFurnitureFactory> factory = new OldFurnitureFactory();

            // act
            var result = factory.CreateTable();

            // assert
            Assert.IsAssignableFrom<Table>(result);
            Assert.IsType<OldTable>(result);

            Assert.Equal(FurnitureStyle.Old, result.FurnitureStyle);
            Assert.Equal(4, result.Legs);
            Assert.Equal(4, result.SeatPositions);
        }

        [Fact]
        public void CreateTable_ReturnsNewFactoryCreatedTable_WhenNewFactoryImplementationUsed()
        {
            // arrange
            IFurnitureFactory<NewFurnitureFactory> factory = new NewFurnitureFactory();

            // act
            var result = factory.CreateTable();

            // assert
            Assert.IsAssignableFrom<Table>(result);
            Assert.IsType<NewTable>(result);

            Assert.Equal(FurnitureStyle.New, result.FurnitureStyle);
            Assert.Equal(6, result.Legs);
            Assert.Equal(8, result.SeatPositions);
        }
    }
}
