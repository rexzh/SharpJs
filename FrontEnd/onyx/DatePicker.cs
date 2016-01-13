using JavaScript;

using enyo;

namespace onyx
{
    /// <summary>
    /// onyx.DatePicker is a group of onyx.Picker controls displaying the current date. The user may change the day, month, and year values.
    /// By default, DatePicker tries to determine the current locale and use its rules to format the date (including the month name). In order to do this successfully, the g11n library must be loaded; if it is not loaded, the control defaults to using standard U.S. date format.
    /// The day field is automatically populated with the proper number of days for the selected month and year.
    /// </summary>
    public class DatePicker : enyo.Control
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
        /// If true, the day field is hidden
        /// </summary>
        public bool DayHidden { get; set; }

        /// <summary>
        /// If true, the month field is hidden
        /// </summary>
        public bool MonthHidden { get; set; }

        /// <summary>
        /// If true, the year field is hidden
        /// </summary>
        public bool YearHidden { get; set; }

        /// <summary>
        /// Optional minimum year value
        /// </summary>
        public int MinYear { get; set; }

        /// <summary>
        /// Optional maximum year value
        /// </summary>
        public int MaxYear { get; set; }

        /// <summary>
        /// The current Date object. When a Date object is passed to setValue(),
        /// the control is updated to reflect the new value. getValue() returns
        /// a Date object.
        /// </summary>
        public DateTime Value { get; set; }

        /// <summary>
        /// Fires when one of the DatePicker's fields is selected.
        /// event.name contains the name of the DatePicker that generated the event.
        /// event.value contains the current Date value of the control.
        /// </summary>
        public EnyoEventHandler<DatePicker, DateTimePickerEventArgs> onSelect;
        
    }
}
