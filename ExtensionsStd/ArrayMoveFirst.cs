using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Move the item selected by predicate in first position of current array
        /// arr.MoveToFront(c => c.ID == 1085);
        /// </summary>
        public static bool MoveFirst<T>(this T[] arr, Predicate<T> match)
        {
            if (arr.Length == 0)
            {
                return false;
            }
            var id = Array.FindIndex(arr, match);
            if (id == -1)
            {
                return false;
            }
            var ret = arr[id];
            Array.Copy(arr, 0, arr, 1, id);
            arr[0] = ret;
            return true;
        }
    }
}
