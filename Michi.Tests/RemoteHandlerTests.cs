using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Functions;
using Michi.Handlers;
using Michi.Messaging;
using Moq;
using Xunit;

namespace Michi.Tests
{
    public class RemoteHandlerTests
    {
        [Fact]
        public void HandleAsyncRequestTest()
        {
            var remoteFunction = RemoteFunction.Make<string>(this.HelloWorld);
            var remoteFunctionContainer = new RemoteFunctionContainer()
            {
                remoteFunction
            };
            var handler = new Mock<AsyncRemoteHandler>(remoteFunctionContainer);
            handler.Setup(x => x.ParsePayload(It.IsAny<object>()))
                .Returns(new RemoteRequest("HelloWorld", "Test", new RemoteFunctionParameters()));
            handler.Setup(x => x.ReturnResponse(It.IsAny<RemoteResponse>()))
                .Callback<RemoteResponse>(response =>
                {
                    Assert.Equal(this.HelloWorld(), response.Result);
                });
            handler.Object.HandleRequest(new {});
        }

        [Fact]
        public void HandleRequestTest()
        {
            var remoteFunction = RemoteFunction.Make<string>(this.HelloWorld);
            var remoteFunctionContainer = new RemoteFunctionContainer()
            {
                remoteFunction
            };
            var handler = new Mock<RemoteHandler>(remoteFunctionContainer);
            handler.Setup(x => x.ParsePayload(It.IsAny<object>()))
                .Returns(new RemoteRequest("HelloWorld", "Test", new RemoteFunctionParameters()));
            handler.Setup(x => x.ReturnResponse(It.IsAny<RemoteResponse>()))
                .Callback<RemoteResponse>(response =>
                {
                    Assert.Equal(this.HelloWorld(), response.Result);
                });
            handler.Object.HandleRequest(new { });
        }

        [RemoteFunction("HelloWorld", "Test")]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
