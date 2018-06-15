using System;
using System.Linq;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Copy props values from an obj to another.
        /// props must have the same name
        /// </summary>
        /// <typeparam name="T">type of source obj</typeparam>
        /// <typeparam name="TU">type of dest obj</typeparam>
        /// <param name="source">source obj</param>
        /// <param name="dest">dest obj</param>
        public static void CopyPropsTo<T, TU>(this T source, TU dest)
        {
            var sourceProps = typeof(T).GetProperties().Where(x => x.CanRead).ToList();
            var destProps = typeof(TU).GetProperties()
                    .Where(x => x.CanWrite)
                    .ToList();

            foreach (var sourceProp in sourceProps)
            {
                if (destProps.Any(x => x.Name == sourceProp.Name))
                {
                    var p = destProps.First(x => x.Name == sourceProp.Name);
                    //check if the property can be set or not.
                    if (p.CanWrite)
                    { 
                        p.SetValue(dest, sourceProp.GetValue(source, null), null);
                    }
                }

            }

        }
    }
}
