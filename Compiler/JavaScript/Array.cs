using System;

namespace JavaScript
{
    [ScriptDefaultValue(Value = "[]")]
    [NonScript]
    public static class ArrayExtension
    {
        public static Array Concat(this Array array, params Array[] arrays)
        {
            return null;
        }

        public static string Join(this Array array, char separator = ',')
        {
            return null;
        }

        public static object Pop(this Array array)
        {
            return null;
        }

        public static void Push(this Array array, params object[] items)
        {
        }

        public static void Reverse(this Array array)
        {
        }

        public static object Shift(this Array array)
        {
            return null;
        }

        public static Array Slice(this Array array, int start)
        {
            return null;
        }

        public static Array Slice(this Array array, int start, int end)
        {
            return null;
        }

        public static Array Sort(this Array array, Func<object, object, int> comparer)
        {
            return null;
        }

        public static Array Splice(this Array array, int index, int removeItemCount, params object[] insertItems)
        {
            return null;
        }

        public static int Unshift(this Array array, params object[] insertItems)
        {
            return 0;
        }

        /*
        public Array ValueOf()
        {
            return null;
        }
        */
    }
}
