using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Adapter.CSharp.Examples.Static
{
    public static class MapperExtensions
    {
        // remove the need for adapter pattern by moving mapping logic into static extension methods and keep the original service implementations
        public static IEnumerable<CustomObject1> ToCustomObject1List(this IEnumerable<CustomObject2> dataList)
        {
            return dataList
                .Select(x => new CustomObject1 {
                    Count = x.NumObjects,
                    SomeProperty = x.SomeProperty,
                    Data = x.Data,              
                }).ToList().AsEnumerable();
        }
    }
}