using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michi.Objects
{
    public class InvalidRemoteObjectException : Exception
    {
        public InvalidRemoteObjectException() : base("Remote Object must not have non-accessible properties.")
        {
            
        }
    }
}
