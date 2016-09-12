using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Michi.Objects
{
    public abstract class RemoteObject
    {
        protected RemoteObject()
        {
            foreach (var property in this.GetType().GetRuntimeProperties())
            {
                if (property.GetSetMethod() == null)
                {
                    throw new InvalidRemoteObjectException();
                }
            }
        }
    }
}
