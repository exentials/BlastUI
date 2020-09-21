using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlastUI.Components
{
    public static class Utils
    {
        public static string GetEnumName<T>(T value)
        {
            if (value == null) return null;
            Type type = typeof(T);
            Type underlyingType = Nullable.GetUnderlyingType(type);
            var name = (underlyingType == null) ? Enum.GetName(type, value) : Enum.GetName(underlyingType, value);
            return name.ToLowerInvariant();
        }
    }
}
