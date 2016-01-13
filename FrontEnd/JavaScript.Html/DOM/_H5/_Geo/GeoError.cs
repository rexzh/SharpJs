using System;

namespace JavaScript.Html.DOM
{
    public abstract class GeoError
    {
        /// <summary>
        /// Match with the constant define in this class
        /// </summary>
        public readonly int Code;

        /// <summary>
        /// User denied the request for Geolocation.
        /// </summary>
        [EvalAtCompile]
        public const int USER_DENY = 1;

        /// <summary>
        /// Location information is unavailable.
        /// </summary>
        [EvalAtCompile]
        public const int UNAVAIL = 2;

        /// <summary>
        /// The request to get user location timed out.
        /// </summary>
        [EvalAtCompile]
        public const int TIME_OUT = 3;
    }
}
