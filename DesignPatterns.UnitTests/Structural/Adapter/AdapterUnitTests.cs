using DesignPatterns.Structural.Adapter.CSharp.Implementation;
using System;
using Xunit;

namespace DesignPatterns.UnitTests.Structural.Adapter
{
    public class AdapterUnitTests
    {
        [Fact]
        public void Invoke_ReturnsOperationBehaviour_WhenDataIsNull()
        {
            // arrange
            IOperation operation = new Operation();
            string data = null;

            // act
            var result = operation.Invoke(data);

            // assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Invoke_ReturnsOperationBehaviour_WhenStringDataProvided()
        {
            // arrange
            IOperation operation = new Operation();
            string data = "some data";

            // act
            var result = operation.Invoke(data);

            // assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void Invoke_ReturnsAdapterOperationBehaviour_WhenDateTimeDataProvided()
        {
            // arrange
            IOperation operation = new Operation();
            var data = DateTimeOffset.UtcNow;
            var adapter = new OperationAdapter(operation);

            // act
            var result = adapter.Invoke(data);

            // assert
            Assert.True(result > 20);
        }
    }
}
