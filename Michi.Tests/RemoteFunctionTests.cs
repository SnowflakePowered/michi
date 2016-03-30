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
            var remoteFunction = RemoteFunction.Make<string>(this.HelloWorld);
            Assert.Equal("HelloWorld", remoteFunction.MethodName);
            Assert.Equal("Test", remoteFunction.MethodNamespace);
        }

        [Fact]
        public void TestMethodTest()
        {
            Assert.Equal("Hello World", this.HelloWorld());
        }

        [Fact]
        public void GetParameterTypesTest()
        {
            var remoteFunction = RemoteFunction.Make<string, string>(this.Echo);
            Assert.Equal(typeof(string), remoteFunction.ParameterTypes?.First().Value);
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
    }
}
