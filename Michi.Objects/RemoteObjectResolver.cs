using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Michi.Objects
{
    public class RemoteObjectResolver
    {
        private IDictionary<Type, Func<object, RemoteObject>> remoteResolvers;
        private IDictionary<Type, Func<RemoteObject, object>> localResolvers;

        public void AddResolver<T>(Expression<Func<T, RemoteObject>> toRemote, Expression<Func<RemoteObject, T>> toLocal)
        {
            var compiledToLocal = toLocal.Compile();
            var compiledToRemote = toRemote.Compile();
            this.localResolvers.Add(typeof(T), x => compiledToLocal(x));
            this.remoteResolvers.Add(typeof(T), x => compiledToRemote((T)x)); //maybe we can rewrite.
        }

        public object ToObject(RemoteObject remoteObject)
        {
            Type t = remoteObject.GetType().GetCustomAttribute<RemoteObjectAttribute>().LocalType;
            return localResolvers.ContainsKey(t) ? localResolvers[t](remoteObject) : remoteObject;
        }

        public RemoteObject ToRemote(object localObject)
        {
            Type t = remoteObject.GetType().GetCustomAttribute<RemoteObjectAttribute>().LocalType;
             
        }
    }
}
