﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Functions;
using Michi.Objects;
using Xunit;

namespace Michi.Tests.Objects
{
    public class RemoteObjectFunctionCallTests
    {
        [Fact]
        public void CallNestedRemoteFunction()
        {
            var container = new RemoteFunctionContainer
            {
                RemoteFunction.Make<int, int, int>(multiply),
                RemoteFunction.Make(two)
            };
            var twoCall = new RemoteFunctionCall()
            {
                FunctionName = "two",
                NamespaceName = "@",
                Parameters = new Dictionary<string, object>(),
            };

            var multiplyCall = new RemoteFunctionCall()
            {
                FunctionName = "multiply",
                NamespaceName = "@",
                Parameters =
                new Dictionary<string, object>{
                    {"a", twoCall},
                    {"b", 4 },
                }
            };

            var rescontainer = new RemoteObjectResolverContainer();
            rescontainer.AddResolver(new TestObjectResolver());

            var functionCallRes = new RemoteFunctionCallResolver(container, rescontainer);
            var resolvedRequest = functionCallRes.ResolveRequest(multiplyCall);
            Assert.Equal(8, resolvedRequest.Result);
        }

        [RemoteFunction("multiply")]
        public int multiply(int a, int b) => a*b;

        [RemoteFunction("two")]
        public int two() => 2;
    }
}