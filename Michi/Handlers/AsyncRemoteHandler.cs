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
    /// Handle a task in an asynchronous manner using the TPL
    /// </summary>
    public abstract class AsyncRemoteHandler : IRemoteHandler
    {
        private readonly RemoteFunctionContainer functionContainer;
        protected AsyncRemoteHandler(RemoteFunctionContainer container)
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
            Task.Run(() => this.functionContainer.Invoke(request))
                .ContinueWith((result) =>
                {
                    this.ReturnResponse(result.Result);
                    this.RequestCompleted?.Invoke(this, new RequestCompletedEventArgs(result.Result));
                });
        }

        /// <summary>
        /// Called after the handle request task completes
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
