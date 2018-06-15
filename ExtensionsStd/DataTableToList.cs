using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Convert a DataTable to a list of T objects
        /// where props has the same names of clomuns
        /// </summary>
        /// <typeparam name="T">Object Type to return</typeparam>
        /// <param name="table">DataTable to convert</param>
        /// <returns>List of T object</returns>
        private static IList<T> ToList<T>(this DataTable table)
        {
            List<T> result = new List<T>();
            foreach (DataRow rw in table.Rows)
            {
                T item = Activator.CreateInstance<T>();
                foreach (DataColumn cl in table.Columns)
                {
                    PropertyInfo pi = typeof(T).GetProperty(cl.ColumnName);

                    if (pi != null && rw[cl] != DBNull.Value)
                        pi.SetValue(item, Convert.ChangeType(rw[cl], pi.PropertyType), new object[0]);
                }
                result.Add(item);
            }
            return result;
        }
    }
}
