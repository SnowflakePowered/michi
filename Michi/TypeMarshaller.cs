using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michi
{
    public class TypeMarshaller
    {
        public void RegisterType<T>(Func<RemoteObject, T> inConverter, Func<T, RemoteObject> outConverter)
        {
            
        }
    }
}
