using CodeGen.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Generators.Property
{
    internal static class PropertyType
    {
        private static Dictionary<DataType, Type> _typeDict = new()
        {
            { DataType.INT, typeof(int) },
            { DataType.STRING, typeof(string)},
            { DataType.DOUBLE, typeof(double)},
            { DataType.DECIMAL, typeof(decimal)},
            { DataType.LONG, typeof(long)}
        };

        public static Type GetPropertyType(DataType dataType)
        {
            if(_typeDict.TryGetValue(dataType, out Type? propertyType) && propertyType is not null)
            {
                return propertyType;
            }

            throw new Exception($"Property type for {dataType} could not be found.");
        }
    }
}
