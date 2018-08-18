using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpClone
{
    public static class CollectionExtension
    {
        // Return a deep clone of a list.
        public static List<T> DeepClone<T>(this List<T> items)
        {
            var query = from T item in items select item.DeepClone();
            return new List<T>(query);
        }

        // Return a deep clone of an array.
        public static T[] DeepClone<T>(this T[] items)
        {
            var query = from T item in items select item.DeepClone();
            return query.ToArray();
        }

        // Return a shallow clone of a list.
        public static List<T> ShallowClone<T>(this List<T> items)
        {
            return new List<T>(items);
        }

        // Return a shallow clone of an array.
        public static T[] ShallowClone<T>(this T[] items)
        {
            return (T[])items.Clone();
        }
    }
}
