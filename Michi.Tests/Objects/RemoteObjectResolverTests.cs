﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Objects;
using Xunit;
using Xunit.Sdk;

namespace Michi.Tests.Objects
{
    public class RemoteObjectResolverTests
    {
        [Fact]
        public void TestResolver()
        {
            var container = new RemoteObjectResolverContainer();
            container.AddResolver(new TestObjectResolver());
            var remoted = container.ToRemote(new TestComplexObject());

            Assert.Equal("Test String From Remote!!", (remoted as TestRemoteObject)?.TestString);
        }
    }

    public class TestObjectResolver: RemoteObjectResolver<TestComplexObject, TestRemoteObject>
    {
        public override TestComplexObject ToObject(TestRemoteObject o) => new TestComplexObject();

        public override TestRemoteObject ToRemote(TestComplexObject o) => new TestRemoteObject()
        {
            TestString = o.TestComplexProperty + " From Remote!!"
        };

    }

    public class IntegerResolver : RemoteObjectResolver<int, RemoteInteger>
    {
        public override int ToObject(RemoteInteger o) => o.Value;
        public override RemoteInteger ToRemote(int o) => new RemoteInteger() {Value = o};
    }
}
