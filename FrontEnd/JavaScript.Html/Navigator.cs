namespace JavaScript.Html
{
    public abstract class Navigator
    {
        /// <summary>
        /// Returns the code name of the browser
        /// </summary>
        public readonly string appCodeName;

        /// <summary>
        /// Returns the name of the browser
        /// </summary>
        public readonly string appName;

        /// <summary>
        /// Returns the version information of the browser
        /// </summary>
        public readonly string appVersion;

        /// <summary>
        /// Determines whether cookies are enabled in the browser
        /// </summary>
        public readonly bool cookieEnabled;

        /// <summary>
        /// Returns for which platform the browser is compiled
        /// </summary>
        public readonly string platform;

        /// <summary>
        /// Returns the user-agent header sent by the browser to the server
        /// </summary>
        public readonly string userAgent;

        /// <summary>
        /// Specifies whether or not the browser has Java enabled
        /// </summary>
        /// <returns></returns>
        public bool JavaEnabled()
        {
            return false;
        }

        public readonly DOM.Geolocation Geolocation;
    }
}
