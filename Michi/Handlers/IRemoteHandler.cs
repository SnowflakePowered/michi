using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michi.Handlers
{
    /// <summary>
    /// A remote handler handles a response from the remote client
    /// </summary>
    public interface IRemoteHandler
    {
        /// <summary>
        /// Handles a request and is responsible for parsing the payload, 
        /// </summary>
        /// <param name="payload">The request payload</param>
        void HandleRequest(object payload);

        /// <summary>
        /// Fired when a requests completes.
        /// </summary>
        event EventHandler<RequestCompletedEventArgs> RequestCompleted;
    }

}
