using System;
using System.Collections;

namespace AshProjeto
{
    public static class TypeExtension
    {
        public static bool IsEmpty(this object value)
        {
            if (value is Hashtable hashTable)
            {
                return hashTable.Count == 0;
            }
            if (value is IDictionary dictionary)
            {
                return dictionary.Count == 0;
            }
            if (value is IList list)
            {
                return list.Count == 0;
            }
            else if (value is Array array)
            {
                return array.Length == 0;
            }
            else
            {
                return value == null;
            }
        }
    }
}
