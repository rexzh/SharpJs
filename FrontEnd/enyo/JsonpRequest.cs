using System;

namespace enyo
{
    public class JsonpRequest : Async
    {
        public static int nextCallbackID;

        public override Async Go(System.Object param = null)
        {
            return null;
        }

        /// <summary>
        /// The URL for the service.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Optional character set to use to interpret the return data
        /// </summary>
        public string Charset { get; set; }

        /// <summary>
        /// Name of the argument that holds the callback name. For example, the Twitter search API uses "callback" as the parameter to hold the name of the called function. We will automatically add this to the encoded arguments.
        /// </summary>
        public string CallbackName { get; set; }

        /// <summary>
        /// When true, appends a random number as a parameter for GET requests to try to force a new fetch of the resource instead of reusing a local cache.
        /// </summary>
        public bool CacheBust { get; set; }
    }
}
