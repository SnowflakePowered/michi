using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michi.Objects
{
    public abstract class RemoteObjectResolver<TLocal, TRemote> 
    {
        public abstract TLocal ToObject(TRemote o);
        public abstract TRemote ToRemote(TLocal o);
    }
}
