using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// If a string is an int16 number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsInt16(this string value)
        {
            return short.TryParse(value, System.Globalization.NumberStyles.Integer, System.Globalization.NumberFormatInfo.InvariantInfo, out short ret);
        }

        /// <summary>
        /// If a string is an int32 number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsInt32(this string value)
        {
            return int.TryParse(value, System.Globalization.NumberStyles.Integer, System.Globalization.NumberFormatInfo.InvariantInfo, out int ret);
        }

        /// <summary>
        /// If a string is an int64 number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsInt64(this string value)
        {
            return long.TryParse(value, System.Globalization.NumberStyles.Integer, System.Globalization.NumberFormatInfo.InvariantInfo, out long ret);
        }

        /// <summary>
        /// If a string is a decimal number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsDecimal(this string value)
        {
            return decimal.TryParse(value, System.Globalization.NumberStyles.Float, System.Globalization.NumberFormatInfo.InvariantInfo, out decimal ret);
        }

        /// <summary>
        /// If a string is a double number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsDouble(this string value)
        {
            return double.TryParse(value, System.Globalization.NumberStyles.Float, System.Globalization.NumberFormatInfo.InvariantInfo, out double ret);
        }

        /// <summary>
        /// If a string is a float number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsFloat(this string value)
        {
            return float.TryParse(value, System.Globalization.NumberStyles.Float, System.Globalization.NumberFormatInfo.InvariantInfo, out float ret);
        }
    }
}
