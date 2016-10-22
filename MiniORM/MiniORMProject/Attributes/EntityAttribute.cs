using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORMProject.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class EntityAttribute : Attribute
    {
        public string TableName { get; set; }
    }
}
