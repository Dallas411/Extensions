using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  return string.Format(value, arg0) where value is the given string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="arg0">An Object to format</param>
        /// <returns>string.Format(value, arg0)</returns>
        public static string Format(this string value, object arg0)
        {
            return string.Format(value, arg0);
        }

        /// <summary>
        ///  return string.Format(value, args) where value is the given string 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="args">An array containing objects to format</param>
        /// <returns>string.Format(value, args)</returns>
        public static string Format(this string value, params object[] args)
        {
            return string.Format(value, args);
        }
    }
}
