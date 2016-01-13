using System;

namespace JavaScript.Html.DOM
{
    public abstract class Storage
    {
        /// <summary>
        /// Return the number of key/value pairs currently present in the list associated with the object.
        /// </summary>
        public readonly ulong Length;

        /// <summary>
        ///  return the name of the nth key in the list.
        ///  The order of keys is user-agent defined, but must be consistent within an object so long as the number of keys doesn't change.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public abstract string Key(ulong index);

        public abstract string GetItem(string key);

        public abstract void SetItem(string key, string value);

        public abstract void RemoveItem(string key);

        public abstract void Clear();
    }
}
