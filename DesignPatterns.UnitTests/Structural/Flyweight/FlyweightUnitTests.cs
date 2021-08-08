using DesignPatterns.Structural.Flyweight.CSharp.RefactoringImplementation.After;
using Xunit;
using System.Runtime.CompilerServices;
using System;

namespace DesignPatterns.UnitTests.Structural.Flyweight
{
    public class FlyweightUnitTests
    {
        [Fact]
        public void FlyweightObject_ShouldShareImageDataReference_WhenUsedForMultipleObjects()
        {
            // arrange
            var commonStaticObject = new CommonStaticImage();

            // act
            var result1 = new FlyweightObject(ref commonStaticObject);
            var result2 = new FlyweightObject(ref commonStaticObject);

            // assert
            Assert.NotEqual(result1.GetRefId(), result2.GetRefId()); // 2 objects should be different
            Assert.Equal(result1.CommonStaticImageData.GetRefId(), result2.CommonStaticImageData.GetRefId()); // but the image data should be shared
        }
    }

    // shorthand extension to return uniqueness of an object, not the object reference itself
    public static class Extensions
    {
        private static readonly ConditionalWeakTable<object, RefId> _ids = new ConditionalWeakTable<object, RefId>();

        public static Guid GetRefId<T>(this T obj) where T : class
        {
            if (obj == null)
                return default(Guid);

            return _ids.GetOrCreateValue(obj).Id;
        }

        private class RefId
        {
            public Guid Id { get; } = Guid.NewGuid();
        }
    }

}
