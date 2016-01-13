using System;

namespace enyo
{
    /// <summary>
    /// enyo.Select implements an HTML selection widget, using enyo.Option kinds by default.
    /// </summary>
    public class Select : Control
    {
        /// <summary>
        /// Returns the value of the selected option.
        /// </summary>
        /// <returns></returns>
        public object GetValue()
        {
            return null;
        }

        /// <summary>
        /// Index of the selected option in the list
        /// </summary>
        public int Selected { get; set; }
    }
}
