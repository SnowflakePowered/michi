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
        private readonly MethodInfo methodInfo;
        private readonly object methodTarget;
        public string MethodNamespace { get; }
        public string MethodName { get; }

        RemoteFunction(MethodInfo methodInfo, object methodTarget, string methodName, string methodNamespace)
        {
            this.methodInfo = methodInfo;
            this.methodTarget = methodTarget;
            this.MethodNamespace = methodNamespace;
            this.MethodName = methodName;
        }

        internal object Invoke(RemoteFunctionParameters remoteParameters)
        {
            ParameterInfo[] parameterInfos = this.methodInfo.GetParameters();
            object[] callingParameters = new object[parameterInfos.Length];
            foreach (var param in parameterInfos)
            {
                callingParameters[param.Position] = remoteParameters.Param(param.Name);
            }
            return this.methodInfo.Invoke(this.methodTarget, callingParameters);
        }
    }
}
