using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michi.Objects
{
    
    [AttributeUsage(AttributeTargets.Class)]
    public class RemoteObjectAttribute : Attribute
    {
        /// <summary>
        /// The type this remote object maps to and from.
        /// </summary>
        public Type LocalType { get; }

        public RemoteObjectAttribute(Type localType)
        {
            this.LocalType = localType;
        }
    }
}
