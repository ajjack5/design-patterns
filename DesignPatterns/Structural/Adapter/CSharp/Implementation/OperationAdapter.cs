using System;

namespace DesignPatterns.Structural.Adapter.CSharp.Implementation
{
    public class OperationAdapter : IOperation
    {
        private readonly IOperation _operation;

        // this is a light spin on the original using composition instead of inheritence - refer to the PowerPoint example for the inheritence approach
        // this adapter construction uses a wrapper implementation to invoke underlying functionality instead of extending on it via a base class
        public OperationAdapter(IOperation operation)
        {
            _operation = operation;
        }

        public int Invoke(string data)
        {
            return _operation.Invoke(data);
        }

        // adaptor with a different data type
        public int Invoke(DateTimeOffset dateTimeOffset)
        {
            string adaptedResult = dateTimeOffset.ToString(); // map result here
            return Invoke(adaptedResult);
        }
    }
}
