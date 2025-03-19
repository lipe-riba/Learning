using System;
using System.Collections;
using System.Security.AccessControl;

namespace AshProjeto
{
    public static class TypeExtension
    {
        public static bool IsEmpty(this Hashtable value)
        {
            bool isEmpty = IsEmpty((object)value);
            return isEmpty | (value?.Count == 0);
        }

        public static bool IsEmpty(this IDictionary value)
        {
            bool isEmpty = IsEmpty((object)value);
            return isEmpty | (value?.Count == 0);
        }

        public static bool IsEmpty(this IList value)
        {
            bool isEmpty = IsEmpty((object)value);
            return isEmpty | (value?.Count == 0);
        }

        public static bool IsEmpty(this Array value)
        {
            bool isEmpty = IsEmpty((object)value);
            return isEmpty | (value?.Length == 0);
        }

        public static bool IsEmpty(this object value)
        {
            return value == null;
        }
    }
}
