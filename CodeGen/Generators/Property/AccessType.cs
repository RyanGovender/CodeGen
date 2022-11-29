using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Generators.Generator.Property
{
    public static class AccessType
    {
        public static FieldAttributes GetAcessType(Enum.AccessType accessType)
        {
            switch(accessType)
            {
                case Enum.AccessType.PUBLIC:
                    return FieldAttributes.Public;
                case Enum.AccessType.PRIVATE:
                    return FieldAttributes.Private;
                default:
                    return FieldAttributes.Private;
            }
        }
    }
}
