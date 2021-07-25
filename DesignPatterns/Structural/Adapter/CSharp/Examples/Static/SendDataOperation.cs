using System.Collections.Generic;

namespace DesignPatterns.Structural.Adapter.CSharp.Examples.Static
{
    public class SendDataOperation : ISendDataOperation
    {
        public bool SendData(IEnumerable<CustomObject1> dataList)
        {
            // do some operation

            return true;
        }
    }
}
