using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michi.Functions
{
    /// <summary>
    /// Marks a method as exportable to the method container
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public sealed class RemoteFunctionAttribute : Attribute
    {
              public RemoteFunctionAttribute(string methodName, string methodNamespace = "@")
        {
            this.MethodName = methodName;
            this.MethodNamespace = methodNamespace;
        }

        /// <summary>
        /// The exported name of the method
        /// </summary>
        public string MethodName { get; }

        /// <summary>
        /// The namespace the method belongs to
        /// </summary>
        public string MethodNamespace { get; }
    }
}
