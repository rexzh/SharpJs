using System;

namespace JavaScript.Html.DOM
{
    public abstract class MediaElement : HtmlElement
    {
        /// <summary>
        /// null if no error
        /// </summary>
        public MediaError Error;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediaType">The media type to test for, such as "video/ogg".</param>
        /// <returns></returns>
        public string CanPlayType(string mediaType)
        {
            return null;
        }

        public void Load()
        {
        }

        /// <summary>
        /// The absolute URL of the chosen media resource (if, for example, the server selects a media file based on the resolution of the user's display), or an empty string if the networkState is EMPTY.
        /// </summary>
        public readonly string CurrentSrc;

        /// <summary>
        /// The URL of the media to present.
        /// </summary>
        public string Src;

        /// <summary>
        /// An object describing the time ranges of the media that have been buffered.
        /// </summary>
        public readonly TimeRanges Buffered;

        /// <summary>
        /// The current state of the fetch of the media.
        /// </summary>
        public readonly MediaNetworkState NetworkState;
        
        /// <summary>
        /// A string indicating what if any data should be preloaded at page load time.
        /// </summary>
        public MediaPreload Preload;
         
        /// <summary>
        /// The media's current readiness state.
        /// </summary>
        public readonly MediaReadyState ReadyState;

        public bool Seeking;

        /// <summary>
        /// The current playback time, in seconds.  Setting this value will seek the media to the new time.
        /// </summary>
        public float CurrentTime;

        /// <summary>
        /// The length of the media in seconds, or zero if no media data is available.
        /// If the media data is available but the length is unknown, this value is NaN.
        /// If the media is streamed and has no predefined length, the value is Inf.
        /// </summary>
        public readonly float Duration;

        /// <summary>
        /// The default playback rate for the media.
        /// 1.0 is "normal speed," values lower than 1.0 make the media play slower than normal, higher values make it play faster. 
        /// </summary>
        public float DefaultPlaybackRate;

        /// <summary>
        /// The current rate at which the media is being played back.
        /// This is used to implement user controls for fast forward, slow motion, and so forth.
        /// The normal playback rate is multiplied by this value to obtain the current rate, so a value of 1.0 indicates normal speed. 
        /// </summary>
        public float PlaybackRate;

        public bool Paused;

        public TimeRanges Played;

        public TimeRanges Seekable;

        public bool Ended;

        public bool AutoPlay;

        public bool Loop;

        public void Play()
        {
        }

        public void Pause()
        {
        }

        public bool Controls;

        /// <summary>
        /// The current audio volume, from 0.0 (silent) to 1.0 (maximum).
        /// </summary>
        public float Volume;

        public bool Muted;
    }
}
