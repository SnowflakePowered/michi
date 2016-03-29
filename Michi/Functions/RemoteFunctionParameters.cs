﻿using System;
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
            object value =  this.parameterDictionary[key];
            if (value is T) return (T)value;
            return default(T);
        }

        internal object Param(string key)
        {
            return this.parameterDictionary.ContainsKey(key) ? this.parameterDictionary[key] : null;
        }

        public void Add(string key, dynamic value)
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
