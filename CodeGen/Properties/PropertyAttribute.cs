using CodeGen.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Properties
{
    public class PropertyAttribute
    {
        public string PropertyName { get; set; }
        public DataType DataType { get; set; }
        public AccessType AccessType { get; set; }
    }
}
