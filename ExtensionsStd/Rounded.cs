using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Like Math.Round
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static decimal Rounded(this decimal value, int decimals)
        {
            return Math.Round(value, decimals);
        }

        /// <summary>
        /// Like Math.Round
        /// </summary>
        /// <param name="value"></param>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static double Rounded(this double value, int digits)
        {
            return Math.Round(value, digits);
        }
    }
}
