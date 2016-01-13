using System;
using JavaScript;

namespace enyo
{
    [RenameClass("enyo")]
    public static class enyoX
    {
        public readonly static AjaxProperties AjaxProperties;
        public readonly static Dom Dom;
        public readonly static FloatingLayer FloatingLayer;

        public readonly static Json Json;
        public readonly static Platform Platform;

        public static void SetLogLevel(int level) { }
        public static void Log(params object[] args) { }
        public static void Warn(params object[] args) { }
        public static void Error(params object[] args) { }

        /// <summary>
        /// Runtime load.
        /// </summary>
        /// <param name="depend">path to package.js, script, or css to load</param>
        public static void Load(string depend) { }

        /// <summary>
        /// Runtime load.
        /// </summary>
        /// <param name="depends">Array of string paths to package.js, script, or css to load</param>
        public static void Load(string[] depends) { }

        /// <summary>
        /// Sets object name to value
        /// </summary>
        /// <param name="name">name can use dot notation and intermediate objects are created as necessary.</param>
        /// <param name="val"></param>
        /// <param name="context">name can be relative to object context.</param>
        /// <returns></returns>
        public static object SetObject(string name, string val, object context = null) { return null; }

        /// <summary>
        /// Gets object
        /// </summary>
        /// <param name="name">name can use dot notation.</param>
        /// <param name="create">Intermediate objects are created if create argument is true.</param>
        /// <param name="context">name can be relative to object context.</param>
        /// <returns></returns>
        public static object GetObject(string name, bool create, object context = null) { return null; }

        /// <summary>
        /// Returns a random Integer between 0 and bound [0, bound).
        /// </summary>
        /// <param name="bound"></param>
        /// <returns></returns>
        public static int Irand(int bound) { return 0; }

        /// <summary>
        /// Returns string with the first letter capitalized.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Cap(string str) { return null; }

        /// <summary>
        /// Returns string with the first letter un-capitalized.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Uncap(string str) { return null; }

        public static string Format(string fmt, params object[] args) { return null; }

        public static bool IsString(object val) { return false; }
        public static bool IsFunction(object val) { return false; }
        public static bool IsArray(object val) { return false; }

        public static int IndexOf<T>(T element, T[] arr, int fromIndex = 0) { return 0; }
        public static void Remove<T>(T element, T[] arr) { }

        public static void ForEach<T>(T[] arr, Action<T> func, object context = null) { }

        public static V[] Map<U, V>(U[] arr, Func<V, U> func, object context = null) { return null; }
        public static T[] Filter<T>(T[] arr, Func<bool, T> func, object context = null) { return null; }

        /// <summary>
        /// Returns an array of all own enumerable properties found on obj.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string[] Keys(object obj) { return null; }

        /// <summary>
        /// Shallow clone.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T[] Clone<T>(T[] arr) { return null; }

        /// <summary>
        /// Shallow clone.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object Clone(object obj) { return null; }

        /// <summary>
        /// Clones an existing Array, or converts an array-like object into an Array, and append them after the startWith.
        /// </summary>
        /// <param name="arrayLike">Array-like objects have length properties, and support square-bracket notation ([]). Often array-like objects do not support Array methods, such as push or concat, and must be converted to Arrays before use.</param>
        /// <param name="offset">If inOffset is non-zero, the cloning is started from that index in the source Array</param>
        /// <param name="startWith">The clone append to</param>
        /// <returns></returns>
        public static Array CloneArray(object arrayLike, int offset = 0, Array startWith = null) { return null; }

        //Note:Same as CloneArray
        //public static Array ToArray() { }

        /// <summary>
        /// Copies custom properties from the source object to the target object. If target is falsey, an object is created. If source is falsey, the target or empty object is returned.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public static object Mixin(object target, object source) { return null; }

        /// <summary>
        /// Equal to: new DateTime().getTime();
        /// </summary>
        /// <returns></returns>
        public static uint Now() { return 0; }

        /// <summary>
        /// Returns a function closure that will call (and return the value of) function method, with scope as this.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="scope"></param>
        /// <param name="func">function to be bind</param>
        /// <param name="args">any number of arguments may be prefixed to the bound function</param>
        /// <returns></returns>
        public static T Bind<T>(object scope, Delegate func, params object[] args) { return default(T); }

        /// <summary>
        /// Returns a function closure that will call (and return the value of) function method, with scope as this.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="scope"></param>
        /// <param name="name">string name of a function-valued property on scope</param>
        /// <param name="args">any number of arguments may be prefixed to the bound function</param>
        /// <returns></returns>
        public static T Bind<T>(object scope, string name, params object[] args) { return default(T); }

        /// <summary>
        /// Calls named method method on obj with optional arguments args (Array), if the object and method exist.
        /// </summary>
        /// <param name="obj">object</param>
        /// <param name="method">method name</param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static object Call(object obj, string method, params object[] args) { return null; }

        /// <summary>
        /// Calls method on obj asynchronously. Uses window.setTimeout with minimum delay, usually around 10ms.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="method"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static object AsyncMethod(object obj, string method, params object[] args) { return null; }

        /// <summary>
        /// Invokes function "work" after "wait" milliseconds have elapsed since the last time "job" was referenced.
        /// </summary>
        /// <param name="job"></param>
        /// <param name="work"></param>
        /// <param name="wait"></param>
        public static void Job(string job, Delegate work, int wait) { }

        /// <summary>
        /// Cancels the named job, if it has not already fired.
        /// In fact it is enyo.job.stop(), since C# does not support this kind syntax.
        /// </summary>
        /// <param name="job"></param>
        [RenameMember("job.stop")]
        public static void JobStop(string job) { }

        /// <summary>
        /// Returns a copy of text, with macros defined by pattern replaced by named values in map.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="map"></param>
        /// <param name="pattern">default is to match {$name}, Dot notation is supported</param>
        /// <returns></returns>
        public static string Macroize(string text, object map, string pattern = "") { return null; }
        public static string QuickMacroize(string text, object map, string pattern = "") { return null; }


        //Extend:don't expose now
        //public static var RequestAnimationFrame() { }
        //public static var CancelRequestAnimationFrame() { }
        //public static var EasedLerp() { }

        /// <summary>
        /// Gets a named value from the document cookie.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetCookie(string name) { return null; }

        /// <summary>
        /// Sets a named value in the document cookie, with properties.
        /// If developing in the Google Chrome browser with a local file as your application, start Chrome with the --enable-file-cookies switch to allow cookies to be set.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="val"></param>
        public static void SetCookie(string name, string val) { }
        /// <summary>
        /// Sets a named value in the document cookie, with properties.
        /// If developing in the Google Chrome browser with a local file as your application, start Chrome with the --enable-file-cookies switch to allow cookies to be set.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="val"></param>
        /// <param name="props">Properties in the optional props argument are attached to the cookie. props may have an expires property, which can be a number of days, a Date object, or a UTC time string.
        /// To remove a cookie, use an props value of { "Max-Age": 0 }.</param>
        public static void SetCookie(string name, string val, object props) { }

        /// <summary>
        /// Allow bootstrapping in environments that do not have a window object right away.
        /// </summary>
        /// <param name="func"></param>
        public static void RequiresWindow(Action func) { }

        [RenameMember("FormData")]
        public static FormData FormData;
    }
}
