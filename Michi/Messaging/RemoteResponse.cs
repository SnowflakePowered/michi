using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Functions;

namespace Michi.Messaging
{
    /// <summary>
    /// Represents a response sent back to the consumer
    /// </summary>
    public class RemoteResponse
    {
        /// <summary>
        /// The response value
        /// </summary>
        public object Response { get; }

        /// <summary>
        /// Whether the execution was a success
        /// </summary>
        public bool IsSuccess { get; }

        /// <summary>
        /// The .NET exception if an error occured
        /// </summary>
        public Exception Error { get; }

        /// <summary>
        /// The request that resulted in the execution of this method
        /// </summary>
        public RemoteRequest CallingRequest { get; }

        public RemoteResponse(object response, bool success, RemoteRequest request, Exception error = null)
        {
            this.Response = response;
            this.IsSuccess = success;
            this.CallingRequest = request;
            this.Error = error;
        }
    }
}
