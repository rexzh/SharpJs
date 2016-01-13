using System;

namespace JavaScript.Html.DOM
{
    public class Geolocation
    {
        private Geolocation() { }

        public void GetCurrentPosition(Action<GeoPosition> successCb, Action<GeoError> errorCb, GeoOptions options)
        {
        }

        public int WatchPosition(Action<GeoPosition> successCb, Action<GeoError> errorCb, GeoOptions options)
        {
            return 0;
        }

        public void ClearWatch(int watchId)
        {
        }
    }
}
