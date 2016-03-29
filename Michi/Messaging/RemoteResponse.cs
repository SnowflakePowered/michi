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
        /// The resulted value
        /// </summary>
        public object Result { get; }

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

        public RemoteResponse(object result, bool success, RemoteRequest request, Exception error = null)
        {
            this.Result = result;
            this.IsSuccess = success;
            this.CallingRequest = request;
            this.Error = error;
        }
    }
}
