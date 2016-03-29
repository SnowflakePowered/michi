using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Functions;
using Xunit;

namespace Michi.Tests
{
    public class EnumeratorTests
    {
        [Fact]
        public void RemoteFunctionParametersEnumeratorTest()
        {
            var x = new RemoteFunctionParameters()
            {
                {"Test", "Hello World"}
            };
            Assert.NotEmpty(x);
            Assert.Equal("Hello World", x.First().Value);
        }

        [Fact]
        public void RemoteFunctionContainerEnumeratorTest()
        {
            var x = new RemoteFunctionContainer()
            {
                RemoteFunction.Make(this.HelloWorld)
            };
            Assert.NotEmpty(x);
            Assert.Equal("HelloWorld", x.First().MethodName);
        }

        [RemoteFunction("HelloWorld", "Test")]
        public void HelloWorld()
        {
            
        }

    }
}
