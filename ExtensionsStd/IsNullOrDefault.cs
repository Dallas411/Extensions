using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Is null or default
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="value">Value to evaluate</param>
        /// <returns>Result</returns>
        public static bool IsNullOrDefault<T>(this T? value) where T : struct
        {
            return default(T).Equals(value.GetValueOrDefault());
        }
    }
}
