using System;

namespace JavaScript.Html.DOM
{
    public abstract class GeoPosition
    {
        private GeoPosition() { }

        public GeoCoords Coords;

        public long Timestamp;
    }
}
