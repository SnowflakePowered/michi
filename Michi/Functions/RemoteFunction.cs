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
        /// <summary>
        /// The exported namespace the method is contained in.
        /// Use this as groups, for example.
        /// </summary>
        public string MethodNamespace { get; }

        /// <summary>
        /// The name of the method
        /// </summary>
        public string MethodName { get; }

        /// <summary>
        /// The parameters and types this function takes.
        /// </summary>
        public IReadOnlyDictionary<string, Type> ParameterTypes { get; }

        RemoteFunction(Func<RemoteFunctionParameters, object> function, string methodName, string methodNamespace, IReadOnlyDictionary<string, Type> parameterTypes)
        {
            this.function = function;
            this.MethodNamespace = methodNamespace;
            this.MethodName = methodName;
            this.ParameterTypes = parameterTypes;
        }

        RemoteFunction(Action<RemoteFunctionParameters> function, string methodName, string methodNamespace, IReadOnlyDictionary<string, Type> parameterTypes)
        {
            this.function = (p) =>
            {
                function(p);
                return null;
            };

            this.MethodNamespace = methodNamespace;
            this.MethodName = methodName;
            this.ParameterTypes = parameterTypes;
        }

        public object Invoke(RemoteFunctionParameters remoteParameters)
        {
            return this.function.Invoke(remoteParameters);
        }
    }
}
