using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Michi.Functions;
namespace Michi.Tests
{
    public class RemoteFunctionArityTests
    {
        [Fact]
        public void Func0() => 
            RemoteFunction.Make<string>(() => "Hello World");
        [Fact]
        public void Func1() => 
            RemoteFunction.Make<object, string>((x) => "Hello World");
        [Fact]
        public void Func2() => 
            RemoteFunction.Make<object, object, string>((x, y) => "Hello World");
        [Fact]
        public void Func3() => 
            RemoteFunction.Make<object, object, object, string>((x, y, z) => "Hello World");
        [Fact]
        public void Func4() => 
            RemoteFunction.Make<object, object, object, object, string>((x, y, z, a) => "Hello World");
        [Fact]
        public void Func5() => 
            RemoteFunction.Make<object, object, object, object, object, string>((x, y, z, a, b) => "Hello World");
        [Fact]
        public void Func6() =>
            RemoteFunction.Make<object, object, object, object, object, object, string>
            ((x, y, z, a, b, c) => "Hello World");
        [Fact]
        public void Func7() => 
            RemoteFunction.Make<object, object, object, object, object, object, object, string>
            ((x, y, z, a, b, c, d) => "Hello World");
        [Fact]
        public void Func8() =>
            RemoteFunction.Make<object, object, object, object, object, object, object, object, string>
            ((x, y, z, a, b, c, d, e) => "Hello World");
        [Fact]
        public void Func9() =>
            RemoteFunction.Make<object, object, object, object, object, object, object, object, object, string>
            ((x, y, z, a, b, c, d, e, f) => "Hello World");
        [Fact]
        public void Func10() => 
            RemoteFunction.Make<object, object, object, object, object, object, object, 
                object, object, object, string>
            ((x, y, z, a, b, c, d, e, f, g) => "Hello World");
        [Fact]
        public void Func11() => 
            RemoteFunction.Make<object, object, object, object, object, object, object,
                object, object, object, object, string>
            ((x, y, z, a, b, c, d, e, f, g, h) => "Hello World");
        [Fact]
        public void Func12() =>
             RemoteFunction.Make<object, object, object, object, object, object, object,
                object, object, object, object, object, string>
            ((x, y, z, a, b, c, d, e, f, g, h, i) => "Hello World");
        [Fact]
        public void Func13() =>
            RemoteFunction.Make<object, object, object, object, object, object, object,
                object, object, object, object, object, object, string>
            ((x, y, z, a, b, c, d, e, f, g, h, i, j) => "Hello World");
        [Fact]
        public void Func14() =>
            RemoteFunction.Make<object, object, object, object, object, object, object,
                object, object, object, object, object, object, object, string>
            ((x, y, z, a, b, c, d, e, f, g, h, i, j, k) => "Hello World");
        [Fact]
        public void Func15() =>
            RemoteFunction.Make<object, object, object, object, object, object, object,
                object, object, object, object, object, object, object, object, string>
            ((x, y, z, a, b, c, d, e, f, g, h, i, j, k, l) => "Hello World");
        [Fact]
        public void Func16() =>
           RemoteFunction.Make<object, object, object, object, object, object, object,
               object, object, object, object, object, object, object, object, object, string>
           ((x, y, z, a, b, c, d, e, f, g, h, i, j, k, l, m) => "Hello World");
        [Fact]
        public void Action0() =>
            RemoteFunction.Make(() => { });
        [Fact]
        public void Action1() =>
            RemoteFunction.Make<object>((x) => { });
        [Fact]
        public void Action2() =>
            RemoteFunction.Make<object, object>((x, y) => { });
        [Fact]
        public void Action3() =>
            RemoteFunction.Make<object, object, object>((x, y, z) => { });
        [Fact]
        public void Action4() =>
            RemoteFunction.Make<object, object, object, object>((x, y, z, a) => { });
        [Fact]
        public void Action5() =>
            RemoteFunction.Make<object, object, object, object, object>((x, y, z, a, b) => { });
        [Fact]
        public void Action6() =>
            RemoteFunction.Make<object, object, object, object, object, object>
            ((x, y, z, a, b, c) => { });
        [Fact]
        public void Action7() =>
            RemoteFunction.Make<object, object, object, object, object, object, object>
            ((x, y, z, a, b, c, d) => { });
        [Fact]
        public void Action8() =>
            RemoteFunction.Make<object, object, object, object, object, object, object, object>
            ((x, y, z, a, b, c, d, e) => { });
        [Fact]
        public void Action9() =>
            RemoteFunction.Make<object, object, object, object, object, object, object, object, object>
            ((x, y, z, a, b, c, d, e, f) => { });
        [Fact]
        public void Action10() =>
            RemoteFunction.Make<object, object, object, object, object, object, object,
                object, object, object>
            ((x, y, z, a, b, c, d, e, f, g) => { });
        [Fact]
        public void Action11() =>
            RemoteFunction.Make<object, object, object, object, object, object, object,
                object, object, object, object>
            ((x, y, z, a, b, c, d, e, f, g, h) => { });
        [Fact]
        public void Action12() =>
             RemoteFunction.Make<object, object, object, object, object, object, object,
                object, object, object, object, object>
            ((x, y, z, a, b, c, d, e, f, g, h, i) => { });
        [Fact]
        public void Action13() =>
            RemoteFunction.Make<object, object, object, object, object, object, object,
                object, object, object, object, object, object>
            ((x, y, z, a, b, c, d, e, f, g, h, i, j) => { });
        [Fact]
        public void Action14() =>
            RemoteFunction.Make<object, object, object, object, object, object, object,
                object, object, object, object, object, object, object>
            ((x, y, z, a, b, c, d, e, f, g, h, i, j, k) => { });
        [Fact]
        public void Action15() =>
            RemoteFunction.Make<object, object, object, object, object, object, object,
                object, object, object, object, object, object, object, object>
            ((x, y, z, a, b, c, d, e, f, g, h, i, j, k, l) => { });
        [Fact]
        public void Action16() =>
           RemoteFunction.Make<object, object, object, object, object, object, object,
               object, object, object, object, object, object, object, object, object>
           ((x, y, z, a, b, c, d, e, f, g, h, i, j, k, l, m) => { });
    }
}
