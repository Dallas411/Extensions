using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// return empty string if source not contains given key
        /// else return given key string value
        /// </summary>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValueOrEmpty(this IDictionary<object, string> source, object key)
        {
            string result;
            if (!source.TryGetValue(key, out result))
                result = string.Empty;
            return result;
        }
    }
}
