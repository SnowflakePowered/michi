using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michi.Objects
{
    [RemoteObject(typeof(int))]
    public class RemoteInteger : RemoteObject
    {
        public int Value { get; set; }
    }
}
