using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Trim all string properties (that have the public setter) of a given object 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T TrimAll<T>(this T obj)
        {
            if (obj != null)
            {
                var stringProperties = obj.GetType().GetProperties()
                              .Where(p => p.PropertyType == typeof(string));

                foreach (var stringProperty in stringProperties)
                {
                    if (stringProperty.GetSetMethod(false) != null && stringProperty.GetSetMethod(false).IsPublic)
                    {
                        string currentValue = (string)stringProperty.GetValue(obj, null);
                        if (currentValue != null)
                            stringProperty.SetValue(obj, currentValue.Trim(), null);
                    }
                }
            }
            return obj;
        }

        /// <summary>
        /// Trim all string properties (that have the public setter) of all elements of given list of T 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objs"></param>
        /// <returns></returns>
        public static List<T> TrimAll<T>(this List<T> objs)
        {
            objs.ForEach(obj =>
            {
                obj.TrimAll();
            });

            return objs;
        }

    }
}
