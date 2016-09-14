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
        private readonly IDictionary<Type, Func<object, object>> remoteResolvers;
        private readonly IDictionary<Type, Func<object, object>> localResolvers;

        public RemoteObjectResolverContainer()
        {
            this.remoteResolvers = new ConcurrentDictionary<Type, Func<object, object>>();
            this.localResolvers = new ConcurrentDictionary<Type, Func<object, object>>();
        }

        public void AddResolver<TLocal, TRemote>(RemoteObjectResolver<TLocal, TRemote> resolver)
        {
            this.AddResolver(o => resolver.ToRemote(o), o => resolver.ToObject((TRemote)o));    
        }

        public void AddResolver<T>(Expression<Func<T, object>> toRemote, Expression<Func<object, T>> toLocal)
        {
            var compiledToLocal = toLocal.Compile();
            var compiledToRemote = toRemote.Compile();
            this.localResolvers.Add(typeof(T), x => compiledToLocal(x));
            this.remoteResolvers.Add(typeof(T), x => compiledToRemote((T)x)); //maybe we can rewrite.
        }

        public object ToObject(object remoteObject)
        {
            Type t = remoteObject.GetType().GetCustomAttribute<RemoteObjectAttribute>()?.LocalType;
            return t != null && localResolvers.ContainsKey(t) ? localResolvers[t](remoteObject) 
                : remoteObject;
        }

        public object ToRemote(object localObject)
        {
            Type t = localObject.GetType();
            return this.remoteResolvers.ContainsKey(t)
                ? this.remoteResolvers[t](localObject)
                : localObject;
        }
    }
}
