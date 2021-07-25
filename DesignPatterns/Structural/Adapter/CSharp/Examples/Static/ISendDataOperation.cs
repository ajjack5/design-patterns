using System.Collections.Generic;

namespace DesignPatterns.Structural.Adapter.CSharp.Examples.Static
{
    public interface ISendDataOperation
    {
        bool SendData(IEnumerable<CustomObject1> dataList);
    }
}
