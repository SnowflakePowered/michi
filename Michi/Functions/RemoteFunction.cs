using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Michi.Messaging;

namespace Michi.Functions
{
    /// <summary>
    /// Represents an exported function that is accessible by consumers
    /// </summary>
    public partial struct RemoteFunction
    {
        private readonly Func<RemoteFunctionParameters, object> function;
        public string MethodNamespace { get; }
        public string MethodName { get; }

        RemoteFunction(Func<RemoteFunctionParameters, object> function, string methodName, string methodNamespace)
        {
            this.function = function;
            this.MethodNamespace = methodNamespace;
            this.MethodName = methodName;
        }

        RemoteFunction(Action<RemoteFunctionParameters> function, string methodName, string methodNamespace)
        {
            this.function = (p) =>
            {
                function(p);
                return null;
            };

            this.MethodNamespace = methodNamespace;
            this.MethodName = methodName;
        }

        public object Invoke(RemoteFunctionParameters remoteParameters)
        {
            return this.function.Invoke(remoteParameters);
        }
    }
}
