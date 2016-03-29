using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Messaging;

namespace Michi.Handlers
{
    /// <summary>
    /// Represents a completed request event
    /// </summary>
    public class RequestCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// The response sent to the client
        /// </summary>
        public RemoteResponse Response { get; }

        public RequestCompletedEventArgs(RemoteResponse response)
        {
            this.Response = response;
        }
    }
}
