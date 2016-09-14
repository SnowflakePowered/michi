using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Functions;
using Michi.Messaging;

namespace Michi.Objects
{
    public class RemoteFunctionCallResolver
    {
        private RemoteFunctionContainer container;
        private RemoteObjectResolverContainer resolver;
        public RemoteFunctionCallResolver(RemoteFunctionContainer container, RemoteObjectResolverContainer resolver)
        {
            this.container = container;
            this.resolver = resolver;
        }

        public RemoteRequest ResolveRequest(RemoteFunctionCall functionCall)
        {
            var remoteParameters = new RemoteFunctionParameters();
            foreach (KeyValuePair<string, object> o in functionCall.Parameters)
            {
                if (!(o.Value is RemoteFunctionCall))
                {
                    remoteParameters.Add(o.Key, resolver.ToObject(o.Value));
                }
                else
                {
                    var localCallResult = container.Invoke(this.ResolveRequest(o.Value as RemoteFunctionCall));
                    //todo error handling
                    remoteParameters.Add(o.Key, localCallResult.Result);
                }
            }
            return new RemoteRequest(functionCall.FunctionName, functionCall.NamespaceName, remoteParameters);
        }
    }
}
