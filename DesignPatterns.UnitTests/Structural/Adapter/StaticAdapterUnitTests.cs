using DesignPatterns.Structural.Adapter.CSharp.Examples.Static;
using System.Collections.Generic;
using Xunit;

namespace DesignPatterns.UnitTests.Structural.Adapter
{
    public class StaticAdapterUnitTests
    {
        [Fact]
        public void Invoke_ReturnsOperationBehaviour_WhenDataIsNull()
        {
            // arrange
            ISendDataOperation operation = new SendDataOperation();
            IList<CustomObject1> data = new List<CustomObject1> {
                new CustomObject1 { Count = 42, Data = "Obi Wan", SomeProperty = 11 },
                new CustomObject1 { Count = 43, Data = "Obi Two", SomeProperty = 45 },
            };

            // act
            var result = operation.SendData(data);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void Invoke_ReturnsOperationBehaviour_WhenDataIsMappedToADifferentFormat()
        {
            // arrange
            ISendDataOperation operation = new SendDataOperation();
            IList<CustomObject2> data = new List<CustomObject2> {
                new CustomObject2 { BackupData = "3245324532534", Data = "agf7gyh345g3noig3", NumObjects = 42, SomeProperty = 534 },
                new CustomObject2 { BackupData = "vbnmtey4h56h5h", Data = "65uherszaadehdhh", NumObjects = 49, SomeProperty = 536 },
            };

            // act
            // remove the need for adapter pattern by moving mapping logic into static extension methods and keep the original service implementations
            var mappedData = data.ToCustomObject1List();
            var result = operation.SendData(mappedData);

            // assert
            Assert.True(result);
        }
    }
}
