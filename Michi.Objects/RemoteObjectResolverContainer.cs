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
    public class RemoteObjectResolverContainer
    {
        private readonly IDictionary<Type, Func<object, RemoteObject>> remoteResolvers;
        private readonly IDictionary<Type, Func<RemoteObject, object>> localResolvers;

        public RemoteObjectResolverContainer()
        {
            this.remoteResolvers = new ConcurrentDictionary<Type, Func<object, RemoteObject>>();
            this.localResolvers = new ConcurrentDictionary<Type, Func<RemoteObject, object>>();
        }

        public void AddResolver<TLocal, TRemote>(RemoteObjectResolver<TLocal, TRemote> resolver) where TRemote : RemoteObject
        {
            this.AddResolver(o => resolver.ToRemote(o), o => resolver.ToObject(o));    
        }

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
            Type t = localObject.GetType();
            return this.remoteResolvers.ContainsKey(t) ? this.remoteResolvers[t](localObject) : null; //todo return something meaningful
        }
    }
}
