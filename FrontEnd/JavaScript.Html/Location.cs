namespace JavaScript.Html
{
    public abstract class Location
    {
        /// <summary>
        /// Returns the anchor portion of a URL
        /// </summary>
        public readonly string hash;

        /// <summary>
        /// Returns the hostname and port of a URL
        /// </summary>
        public readonly string host;

        /// <summary>
        /// Returns the hostname of a URL
        /// </summary>
        public readonly string hostname;

        /// <summary>
        /// Returns the entire URL
        /// </summary>
        public readonly string href;

        /// <summary>
        /// Returns the path name of a URL
        /// </summary>
        public readonly string pathname;

        /// <summary>
        /// Returns the port number the server uses for a URL
        /// </summary>
        public readonly int port;

        /// <summary>
        /// Returns the protocol of a URL
        /// </summary>
        public readonly string protocol;

        /// <summary>
        /// Returns the query portion of a URL
        /// </summary>
        public readonly string search;

        /// <summary>
        /// Loads a new document
        /// </summary>
        /// <param name="url"></param>
        public void Assign(string url)
        {
        }

        /// <summary>
        /// Reloads the current document
        /// </summary>
        public void Reload()
        {
        }

        /// <summary>
        /// Replaces the current document with a new one
        /// </summary>
        /// <param name="newUrl"></param>
        public void Replace(string newUrl)
        {
        }
    }
}
