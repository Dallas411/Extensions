using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// For a given object returns the value of a given property  
        /// Like GetType().GetProperty(propertyName).GetValue(obj)
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName">the property of which to return the value</param>
        /// <returns></returns>
        public static object GetPropertyValue(this object obj, string propertyName)
        {
            if (obj.GetType().GetProperty(propertyName) != null)
                return obj.GetType().GetProperty(propertyName).GetValue(obj);
            else
                return null;

        }
    }
}
