using System;

namespace enyo
{
    public class AjaxProperties
    {
        /// <summary>
        /// When true, appends a random number as a parameter for GET requests to try to force a new fetch of the resource instead of reusing a local cache.
        /// </summary>
        public bool CacheBust;

        /// <summary>
        /// The URL for the service. This can be a relative URL if used to fetch resources bundled with the application.
        /// </summary>
        public string Url;

        /// <summary>
        /// The HTTP method to use for the request, defaults to GET. Supported values include "GET", "POST", "PUT", and "DELETE".
        /// </summary>
        public string Method;

        /// <summary>
        /// How the response will be handled. Supported values are: "json", "text", "xml"
        /// Check HandleAs class.
        /// </summary>
        public HandleAs HandleAs;

        /// <summary>
        /// The Content-Type header for the request as a String.
        /// </summary>
        public string ContentType;

        /// <summary>
        /// If true, makes a synchronous (blocking) call, if supported. Synchronous requests are not supported on HP webOS.
        /// </summary>
        public bool Sync;

        /// <summary>
        /// Optional additional request headers as a JS object, e.g. { "X-My-Header": "My Value", "Mood": "Happy" } or null.
        /// </summary>
        public object Headers;

        /// <summary>
        /// The content for the request body for POST method. If this is not set, params will be used instead.
        /// </summary>
        public string PostBody;

        /// <summary>
        /// The optional user name to use for authentication purposes.
        /// </summary>
        public string Username;

        /// <summary>
        /// The optional password to use for authentication purposes.
        /// </summary>
        public string Password;

        /// <summary>
        /// Optional object with fields to pass directly to the underlying XHR object.
        /// </summary>
        public object XhrFields;

        /// <summary>
        /// Optional string to override the MIME-Type.
        /// </summary>
        public string MimeType;
    }
}
