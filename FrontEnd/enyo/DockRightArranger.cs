using System;

namespace enyo
{
    /// <summary>
    /// enyo.DockRightArranger is an enyo.Arranger that displays the active control, along with some number of inactive controls to fill the available space. The active control is positioned on the right side of the container and the rest of the views are laid out to the right.
    /// For best results with DockRightArranger, you should set a minimum width for each control via a CSS style, e.g., min-width: 25% or min-width: 250px.
    /// </summary>
    public class DockRightArranger : Arranger
    {
        /// <summary>
        /// If true, the base panel (index 0) will fill the width of the container, while newer controls will slide in and collapse on top of it
        /// </summary>
        public bool BasePanel;

        /// <summary>
        /// How many px should panels overlap
        /// </summary>
        public int Overlap;

        /// <summary>
        /// Column width
        /// </summary>
        public int LayoutWidth;
    }
}
