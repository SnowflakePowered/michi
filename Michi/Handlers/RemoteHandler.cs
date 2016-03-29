using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Functions;
using Michi.Messaging;

namespace Michi.Handlers
{
    /// <summary>
    /// A base implementation of how to handle a response
    /// </summary>
    public abstract class RemoteHandler : IRemoteHandler
    {
        private readonly RemoteFunctionContainer functionContainer;
        protected RemoteHandler(RemoteFunctionContainer container)
        {
            this.functionContainer = container;
        }

        /// <summary>
        /// Handles a request and is responsible for parsing the payload, 
        /// </summary>
        /// <param name="payload">The request payload</param>
        public void HandleRequest(object payload)
        {
            var request = this.ParsePayload(payload);
            var response = this.functionContainer.Invoke(request);
            this.ReturnResponse(response);
            this.RequestCompleted?.Invoke(this, new RequestCompletedEventArgs(response));
        }

        /// <summary>
        /// Called at the end of HandleRequest
        /// </summary>
        public event EventHandler<RequestCompletedEventArgs> RequestCompleted;

        /// <summary>
        /// Parses a payload into a RemoteRequest
        /// </summary>
        /// <param name="payload">The payload from the consumer</param>
        /// <returns>The remote request</returns>
        public abstract RemoteRequest ParsePayload(object payload);

        /// <summary>
        /// Returns a response back to the consumer
        /// </summary>
        /// <param name="response">The response to return</param>
        public abstract void ReturnResponse(RemoteResponse response);
    }
}
