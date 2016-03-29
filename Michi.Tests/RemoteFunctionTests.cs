using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Functions;
using Xunit;

namespace Michi.Tests
{
    public class RemoteFunctionTests
    {
        [Fact]
        public void MakeSingularTest()
        {
            var remoteFunction = RemoteFunction.Make(this.HelloWorld);
            Assert.Equal("HelloWorld", remoteFunction.MethodName);
            Assert.Equal("Test", remoteFunction.MethodNamespace);
        }

        [RemoteFunction("HelloWorld", "Test")]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
