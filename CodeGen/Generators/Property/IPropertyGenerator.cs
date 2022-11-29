using CodeGen.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Generators.Generator.Property
{
    public interface IPropertyGenerator
    {
        TypeBuilder CreateProperty(PropertyAttribute propertyAttribute);
    }
}
