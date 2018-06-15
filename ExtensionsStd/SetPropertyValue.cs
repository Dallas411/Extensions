using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Set the value of a property of an object
        /// Similar to GetType().GetProperty(propertyName).SetValue(obj, value)
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName">The name of the property to return the value</param>
        /// <returns></returns>
        public static object SetPropertyValue(this object obj, string propertyName, object value)
        {
            PropertyInfo propertyInfo = obj.GetType().GetProperty(propertyName);
            propertyInfo.SetValue(obj, Convert.ChangeType(value, propertyInfo.PropertyType), null);

            return obj;
        }
    }
}
