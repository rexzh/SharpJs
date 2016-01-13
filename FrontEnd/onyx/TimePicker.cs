using JavaScript;
using enyo;

namespace onyx
{
    /// <summary>
    /// onyx.TimePicker is a group of onyx.Picker controls displaying the current time. The user may change the hour, minute, and AM/PM values.
    /// By default, TimePicker tries to determine the current locale and use its rules to format the time (including AM/PM). In order to do this successfully, the g11n library must be loaded; if it is not loaded, the control defaults to using standard U.S. time format.
    /// </summary>
    public class TimePicker : enyo.Control
    {
        /// <summary>
        /// If true, control is shown as disabled, and user can't select new values
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// Current locale used for formatting. Can be set after control
        /// creation, in which case the control will be updated to reflect the new value.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// If true, 24-hour time is used. This is reset when locale is changed.
        /// </summary>
        public bool Is24HrMode { get; set; }


        /// <summary>
        /// The current Date object. When a Date object is passed to setValue, the control is updated to reflect the new value. getValue returns a Date object.
        /// </summary>
        public DateTime Value { get; set; }

        /// <summary>
        /// Fires when one of the TimePicker's fields is selected.
        /// inEvent.name contains the name of the TimePicker that generated the event.
        /// inEvent.value contains the current Date value of the control.
        /// </summary>
        public EnyoEventHandler<DatePicker, DateTimePickerEventArgs> onSelect;        
    }
}
