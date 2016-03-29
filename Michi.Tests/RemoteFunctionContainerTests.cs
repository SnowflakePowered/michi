using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Functions;
using Xunit;

namespace Michi.Tests
{
    public class RemoteFunctionContainerTests
    {
        [Fact]
        public void AddTest()
        {
            var remoteFunction = RemoteFunction.Make(this.HelloWorld);
            var remoteFunctionContainer = new RemoteFunctionContainer()
            {
                remoteFunction
            };
            Assert.Contains(remoteFunction, remoteFunctionContainer);
        }

        [Fact]
        public void InvokeTest()
        {
            var remoteFunction = RemoteFunction.Make(this.HelloWorld);
            var remoteFunctionContainer = new RemoteFunctionContainer()
            {
                remoteFunction
            };
            var response = remoteFunctionContainer.Invoke(new Messaging.RemoteRequest("HelloWorld", "Test",
                new RemoteFunctionParameters()));
            Assert.Equal("Hello World", response.Response);
            Assert.True(response.IsSuccess);
        }


        [Fact]
        public void InvokeWithParamsTest()
        {
            var remoteFunction = RemoteFunction.Make<string, string>(this.Echo);
            var remoteFunctionContainer = new RemoteFunctionContainer()
            {
                remoteFunction
            };
            var response = remoteFunctionContainer.Invoke(new Messaging.RemoteRequest("Echo", "Test",
                new RemoteFunctionParameters()
                {
                    {"echo", "Hello World"}
                }));
            Assert.Equal("Hello World", response.Response);
            Assert.True(response.IsSuccess);
        }

        [Fact]
        public void InvokeWithErrorTest()
        {
            var remoteFunction = RemoteFunction.Make(this.Error);
            var remoteFunctionContainer = new RemoteFunctionContainer()
            {
                remoteFunction
            };
            var response = remoteFunctionContainer.Invoke(new Messaging.RemoteRequest("Error", "Test",
               new RemoteFunctionParameters()));
            Assert.False(response.IsSuccess);
            Assert.NotNull(response.Error);
            Assert.Equal("Hello World", response.Error.Message);
        }


        [RemoteFunction("HelloWorld", "Test")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [RemoteFunction("Echo", "Test")]
        public string Echo(string echo)
        {
            return echo;
        }

        [RemoteFunction("Error", "Test")]
        public string Error()
        {
           throw new Exception("Hello World");
        }
    }
}
