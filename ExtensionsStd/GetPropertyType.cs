using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// For a given object returns the type of a given property  
        /// Like GetType().GetProperty(propertyName).PropertyType
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static object GetPropertyType(this object obj, string propertyName)
        {
            try
            {
                return obj.GetType().GetProperty(propertyName).PropertyType;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}
