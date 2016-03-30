using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michi.Functions
{
    /// <summary>
    /// Represents a keyed collection of function parameters.
    /// Once added, parameters can not be accessed individually, but can be iterated upon.
    /// </summary>
    public class RemoteFunctionParameters : IEnumerable<KeyValuePair<string, object>>
    {
        private readonly IDictionary<string, dynamic> parameterDictionary;

        public RemoteFunctionParameters()
        {
            this.parameterDictionary = new ConcurrentDictionary<string, object>();
        }

         internal T Param<T>(string key)
         {
            if (!this.parameterDictionary.ContainsKey(key)) return default(T);
            object value = this.parameterDictionary[key];
            return (value is T) ? (T)value : default(T);
         }

        public void Add(string key, object value)
        {
            this.parameterDictionary.Add(key, value);
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return this.parameterDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
