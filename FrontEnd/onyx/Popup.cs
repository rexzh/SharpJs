using JavaScript;

namespace onyx
{
    public class Popup : enyo.Popup
    {
        /// <summary>
        /// Determines whether a scrim will appear when the dialog is modal. Note that modal scrims are transparent, so you won't see them.
        /// </summary>
        public bool ScrimWhenModal { get; set; }

        /// <summary>
        /// Determines whether or not to display a scrim. Only displays scrims when floating.
        /// </summary>
        public bool Scrim { get; set; }

        /// <summary>
        /// Optional class name to apply to the scrim. Be aware that the scrim is a singleton and you will be modifying the scrim instance used for other popups.
        /// </summary>
        public string ScrimClassName { get; set; }
    }
}
