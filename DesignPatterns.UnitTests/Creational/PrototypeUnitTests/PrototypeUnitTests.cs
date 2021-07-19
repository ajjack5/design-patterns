using DesignPatterns.Creational.Prototype.CSharp.Implementation;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.PrototypeUnitTests
{
    public class PrototypeUnitTests
    {
        [Fact]
        public void Clone_InitialisesANewCopyOfThePrototypeObject_WhenInvoked()
        {
            // arrange
            var prototype = new CloneableObject();

            // act
            var result = prototype.Clone();

            // assert
            Assert.NotNull(result);
            
            var prototypeRef = prototype.GetHashCode();
            var clonedPrototype = result.GetHashCode();

            Assert.NotEqual(prototypeRef, clonedPrototype);
        }

        [Fact]
        public void Clone_ClonesOriginalObjectProperties_WhenPropertiesExist()
        {
            // arrange
            var prototype = new CloneableObject();
            prototype.SpecificObjectData = 42;
            prototype.SharedData = 10;
            prototype.OtherSharedData = 5;

            // act
            var result = prototype.Clone();

            // assert
            Assert.Equal(prototype.SpecificObjectData, result.SpecificObjectData);
            Assert.Equal(prototype.SharedData, result.SharedData);
            Assert.Equal(prototype.OtherSharedData, result.OtherSharedData);
        }

        [Fact]
        public void Clone_ClonesOriginalObjectProperties_EnsuringChangesToOneObjectDontAffectTheOther()
        {
            // arrange
            var prototype = new CloneableObject();
            prototype.SpecificObjectData = 42;
            prototype.SharedData = 10;
            prototype.OtherSharedData = 5;

            // act
            var result = prototype.Clone();

            prototype.SpecificObjectData = 55;
            prototype.SharedData = 77;
            prototype.OtherSharedData = 99;

            // assert
            Assert.NotEqual(prototype.SpecificObjectData, result.SpecificObjectData);
            Assert.NotEqual(prototype.SharedData, result.SharedData);
            Assert.NotEqual(prototype.OtherSharedData, result.OtherSharedData);
        }
    }
}
