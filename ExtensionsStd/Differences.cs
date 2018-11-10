using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Check the differences between the properties of two instances of the same class
        /// Returns the list of properties names with different values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="original"></param>
        /// <param name="modified"></param>
        /// <param name="equalNullAndWhiteSpace">Determines whether to consider the same values ​​as nulls and spaces (only for strings)</param>
        /// <param name="ignoreProperties">Prop not to consider</param>
        /// <returns></returns>
        public static List<string> Differences<T>(this T original, T modified, bool equalNullAndWhiteSpace = false, List<string> ignoreProperties = null)
        {
            List<string> differences = new List<string>();
            foreach (PropertyInfo pi in typeof(T).GetProperties())
            {
                var prop = pi.Name.ToString();
                if ((ignoreProperties != null && !ignoreProperties.Contains(prop)) || ignoreProperties == null)
                {
                    var originalVal = pi.GetValue(original);
                    var modifiedVal = pi.GetValue(modified);
                    if (pi.PropertyType == typeof(string) && equalNullAndWhiteSpace)
                    {
                        if (originalVal == null || string.IsNullOrWhiteSpace(originalVal.ToString())) originalVal = null;
                        if (modifiedVal == null || string.IsNullOrWhiteSpace(modifiedVal.ToString())) modifiedVal = null;
                    }
                    if ((originalVal != null && !originalVal.Equals(modifiedVal)) || (originalVal == null && modifiedVal != null))
                        differences.Add(prop);
                }
            }
            return differences;
        }
    }
}
