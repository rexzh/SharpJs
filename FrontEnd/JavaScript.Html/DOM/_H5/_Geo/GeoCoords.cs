using System;

namespace JavaScript.Html.DOM
{
    public abstract class GeoCoords
    {
        public readonly decimal Latitude;
        public readonly decimal Longitude;
        public readonly decimal Accuracy;

        public readonly decimal Altitude;
        public readonly decimal AltitudeAccuracy;
        /// <summary>
        /// The heading as degrees clockwise from North
        /// </summary>
        public readonly decimal Heading;
        /// <summary>
        /// The speed in meters per second
        /// </summary>
        public readonly decimal Speed;
    }
}
