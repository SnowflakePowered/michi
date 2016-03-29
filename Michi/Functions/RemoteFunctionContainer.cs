using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Michi.Messaging;

namespace Michi.Functions
{
    /// <summary>
    /// Represents a container of exported remote functions
    /// </summary>
    public class RemoteFunctionContainer : IEnumerable<RemoteFunction>
    {
        private readonly IDictionary<string, RemoteFunction> methodContainer;

        public IEnumerator<RemoteFunction> GetEnumerator()
        {
            return this.methodContainer.Select(kvp => kvp.Value).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public RemoteFunctionContainer()
        {
            this.methodContainer = new ConcurrentDictionary<string, RemoteFunction>();
        }

        public void Add(RemoteFunction function)
        {
            this.methodContainer.Add($"{function.MethodNamespace}.{function.MethodName}", function);
        }

        /// <summary>
        /// Invokes the exported function and returns a response
        /// </summary>
        public RemoteResponse Invoke(RemoteRequest request)
        {
            if (!this.methodContainer.ContainsKey($"{request.Namespace}.{request.MethodName}"))
                return new RemoteResponse(null, false, request, new KeyNotFoundException($"Method {request.MethodName} was not found in remote method namespace {request.Namespace}."));
            try
            {
                var retVal =
                    this.methodContainer[$"{request.Namespace}.{request.MethodName}"].Invoke(request.CallingParameters);
                return new RemoteResponse(retVal, true, request);
            }
            catch (Exception e)
            {
                return new RemoteResponse(null, false, request, e.InnerException ?? e);
            }

        }
    }
}
