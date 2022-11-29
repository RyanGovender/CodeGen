using CodeGen.Generators.Property;
using CodeGen.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Generators.Generator.Property
{
    public class PropertyGenerator : IPropertyGenerator
    {

        public TypeBuilder CreateProperty(TypeBuilder tb, PropertyAttribute propertyAttribute)
        {
            Type propertyType = PropertyType.GetPropertyType(propertyAttribute.DataType);
            FieldAttributes fieldAttributes = AccessType.GetAcessType(propertyAttribute.AccessType);

            FieldBuilder fieldBuilder = 
                tb.DefineField($"_{propertyAttribute.PropertyName}", propertyType, fieldAttributes);

            throw new NotImplementedException();
        }
    }
}
