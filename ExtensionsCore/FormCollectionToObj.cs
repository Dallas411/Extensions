using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace ExtensionsCore
{
    public static partial class CommonExtensions
    {
        public static T ToObj<T>(this FormCollection dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (System.Reflection.PropertyInfo pro in temp.GetProperties())
            {
                var y = dr[pro.Name].ToString();

                if (y == null) continue;

                if (pro.PropertyType.IsGenericType && pro.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    pro.SetValue(obj, Convert.ChangeType(y, Nullable.GetUnderlyingType(pro.PropertyType)));
                }
                else
                {
                    //se è un tipo numerico non nullabile imposto un valore di default.
                    if ((IsNumericType(pro)) && string.IsNullOrWhiteSpace(y) && !IsNullableType(pro))
                        y = "0";

                    //if ((IsNumericType(pro)) && string.IsNullOrWhiteSpace(y) && IsNullableType(pro))
                    //    y = null;

                    if (IsNumericType(pro) && y.EndsWith(","))
                        y = new string(y.Take(y.Length - 1).ToArray());

                    pro.SetValue(obj, Convert.ChangeType(y, pro.PropertyType));
                }
            }
            return obj;
        }

        private static bool IsNumericType(System.Reflection.PropertyInfo pro)
        {
            switch (Type.GetTypeCode(pro.PropertyType))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }

        private static bool IsNullableType(System.Reflection.PropertyInfo pro)
        {
            return pro.PropertyType.IsGenericType && pro.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
    }
}
