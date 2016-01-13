using System;

namespace JavaScript.Html.DOM
{
    public abstract class DomEvent
    {
        /// <summary>
        /// Returns whether or not the "ALT" key was pressed when an event was triggered.
        /// </summary>
        public bool AltKey;

        /// <summary>
        /// Returns whether or not the "CTRL" key was pressed when an event was triggered.
        /// </summary>
        public bool CtrlKey;

        /// <summary>
        /// Returns whether or not the "meta" key was pressed when an event was triggered.
        /// </summary>
        public bool MetaKey;

        /// <summary>
        /// Returns whether or not the "SHIFT" key was pressed when an event was triggered.
        /// </summary>
        public bool ShiftKey;

        /// <summary>
        /// Returns the horizontal coordinate of the mouse pointer when an event was triggered.
        /// </summary>
        public int ClientX;

        /// <summary>
        /// Returns the vertical coordinate of the mouse pointer when an event was triggered.
        /// </summary>
        public int ClientY;

        /// <summary>
        /// Returns the horizontal coordinate of the mouse pointer when an event was triggered.
        /// </summary>
        public int ScreenX;

        /// <summary>
        /// Returns the vertical coordinate of the mouse pointer when an event was triggered.
        /// </summary>
        public int ScreenY;

        /// <summary>
        /// Returns which mouse button was clicked when an event was triggered.
        /// </summary>
        //Extend: Each browser have different define??
        public int Button;

        /// <summary>
        /// Returns a Boolean value that indicates whether or not an event is a bubbling event.
        /// </summary>
        public bool Bubbles;

        /// <summary>
        /// Returns a Boolean value that indicates whether or not an event can have its default action prevented.
        /// </summary>
        public bool Cancelable;

        /// <summary>
        /// IE 8- Returns the element that triggered the event.
        /// </summary>
        public HtmlElement SrcElement;

        /// <summary>
        /// Returns the element related to the element that triggered the event
        /// </summary>
        public HtmlElement RelatedTarget;

        /// <summary>
        /// Returns the element whose event listeners triggered the event
        /// </summary>
        public HtmlElement CurrentTarget;


        /// <summary>
        /// Returns the element that triggered the event.
        /// </summary>
        public HtmlElement Target;

        /// <summary>
        /// Returns the time stamp, in milliseconds, from the epoch (system start or event trigger)
        /// </summary>
        public long TimeStamp;

        /// <summary>
        /// Returns the name of the event
        /// </summary>
        public string Type;
    }
}
