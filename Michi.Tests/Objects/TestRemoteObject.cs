using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michi.Objects;

namespace Michi.Tests.Objects
{
    [RemoteObject(typeof(TestComplexObject))]
    public class TestRemoteObject
    {
        public string TestString { get; set; }
    }
}
