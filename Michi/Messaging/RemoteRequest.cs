using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Functions;

namespace Michi.Messaging
{
    /// <summary>
    /// Represents a remote request sent from the consumer
    /// </summary>
    public struct RemoteRequest
    {
        /// <summary>
        /// The namespace of the requested method to call
        /// </summary>
        public string Namespace { get; }

        /// <summary>
        /// The name of the requested method to call
        /// </summary>
        public string MethodName { get; }

        /// <summary>
        /// The parameters to call this method with
        /// </summary>
        public RemoteFunctionParameters CallingParameters { get; }

        public RemoteRequest(string methodName, string methodNamespace, RemoteFunctionParameters callingParameters)
        {
            this.Namespace = methodNamespace;
            this.MethodName = methodName;
            this.CallingParameters = callingParameters;
        }
    }
}
