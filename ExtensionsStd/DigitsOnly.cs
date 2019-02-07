using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Return only digits from a given string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DigitsOnly(this string value)
        {
            if (value!=null)
                return new string(value.Where(c => char.IsDigit(c)).ToArray());
            else
                return null;
        }
    }
}
