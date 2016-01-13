using JavaScript;

namespace enyo
{
    public class Ajax : Async
    {
        public Ajax(AjaxProperties init)
        {
        }

        public override Async Go(System.Object param = null)
        {
            return null;
        }

        /// <summary>
        /// When true, appends a random number as a parameter for GET requests to try to force a new fetch of the resource instead of reusing a local cache.
        /// </summary>
        public bool CacheBust { get; set; }

        /// <summary>
        /// The URL for the service. This can be a relative URL if used to fetch resources bundled with the application.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The HTTP method to use for the request, defaults to GET. Supported values include "GET", "POST", "PUT", and "DELETE".
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// How the response will be handled. Supported values are: "json", "text", "xml"
        /// Check HandleAs class.
        /// </summary>
        public HandleAs HandleAs { get; set; }

        /// <summary>
        /// The Content-Type header for the request as a String.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// If true, makes a synchronous (blocking) call, if supported. Synchronous requests are not supported on HP webOS.
        /// </summary>
        public bool Sync { get; set; }

        /// <summary>
        /// Optional additional request headers as a JS object, e.g. { "X-My-Header": "My Value", "Mood": "Happy" } or null.
        /// </summary>
        public JavaScript.Object Headers { get; set; }

        /// <summary>
        /// The content for the request body for POST method. If this is not set, params will be used instead.
        /// </summary>
        public string PostBody { get; set; }

        /// <summary>
        /// The optional user name to use for authentication purposes.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The optional password to use for authentication purposes.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Optional object with fields to pass directly to the underlying XHR object.
        /// </summary>
        public object XhrFields { get; set; }

        /// <summary>
        /// Optional string to override the MIME-Type.
        /// </summary>
        public string MimeType { get; set; }


        /// <summary>
        /// Only available when complete.
        /// </summary>
        public XhrResponse XhrResponse;
    }

    [NonScript]
    public sealed class XhrResponse : JavaScript.Object
    {
        public int Status;
        public JavaScript.Object Headers;
        public string Body;
    }
}
