using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michi.Objects
{
    public class RemoteFunctionCall 
    {
        public string NamespaceName { get; set; }
        public string FunctionName { get; set; }
        public IDictionary<string, object> Parameters { get; set; }
    }
}
