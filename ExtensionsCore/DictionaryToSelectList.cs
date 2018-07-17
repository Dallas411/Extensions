using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionsCore
{
    public static partial class CommonExtensions
    {
        public static SelectList ToSelectList(this Dictionary<string, string> keyValue, object selected)
        {
            if (selected == null)
                return new SelectList(keyValue.ToList(), "Key", "Value");
            else
                return new SelectList(keyValue.ToList(), "Key", "Value", selected);
        }
    }
}
