using JavaScript;

namespace enyo
{
    [NonScript]
    public class Platform
    {
        public int? Android;
        public int? AndroidChrome;
        public int? Ie;
        public int? Ios;
        public int? Webos;
        public int? Safari;
        public int? Chrome;
        public int? Blackberry;

        /// <summary>
        /// True if the platform has native single finger events
        /// </summary>
        public bool Touch;

        /// <summary>
        /// True if the platform has native double finger events
        /// </summary>
        public bool Gesture;
    }
}
