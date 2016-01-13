using System;

namespace JavaScript.Html.DOM
{
    public abstract class MediaNetworkState
    {
        public static implicit operator MediaNetworkState(int val)
        {
            return null;
        }

        private MediaNetworkState() { }

        /// <summary>
        /// Not yet initialized
        /// </summary>
        [EvalAtCompile]
        public const int NETWORK_EMPTY = 0;

        /// <summary>
        /// Network is not being used now (video is completely loaded for example)
        /// </summary>
        [EvalAtCompile]
        public const int NETWORK_IDLE = 1;

        /// <summary>
        /// Browser is loading data from the net
        /// </summary>
        [EvalAtCompile]
        public const int NETWORK_LOADING = 2;

        /// <summary>
        /// Data has been loaded
        /// </summary>
        [EvalAtCompile]
        public const int NETWORK_LOADED = 3;

        /// <summary>
        /// Video resource could not be found/loaded
        /// </summary>
        [EvalAtCompile]
        public const int NETWORK_NO_SOURCE = 4;
    }
}
