using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Remove a list of T object from source List<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="objsToRemove"></param>
        /// <returns></returns>
        public static List<T> RemoveRange<T>(this List<T> source, List<T> objsToRemove)
        {
            objsToRemove.ForEach(objToRemove =>
            {
                source.Remove(objToRemove);
            });
            return source;
        }
    }
}
