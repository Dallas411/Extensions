using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Never throw an exception like
        /// instead it happens with standard String.substring
        /// </summary>
        /// <param name="value"></param>
        /// <param name="skip">number of char to skip</param>
        /// <param name="take">number of char to return</param>
        /// <returns></returns>
        public static string Substring(this string value, int skip, int take)
        {
            return new string(value.Skip(skip).Take(take).ToArray());
        }
    }
}
