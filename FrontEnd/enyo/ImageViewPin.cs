using System;

namespace enyo
{
    public class ImageViewPin : enyo.Control
    {
        /// <summary>
        /// If true, the anchor point for this pin will be highlighted in yellow, which can be useful for debugging. Defaults to false.
        /// </summary>
        public bool HighlightAnchorPoint { get; set; }

        /// <summary>
        /// The coordinates at which this control should be anchored inside of the parent ImageView control. This position is relative to the ImageView control's original size. Works like standard CSS positioning, and accepts both px and percentage values. Defaults to {top: 0px, left: 0px}.
        /// <para>top: distance from the parent's top edge</para>
        /// <para>bottom: distance from the parent's bottom edge (overrides top)</para>
        /// <para>left: distance from the parent's left edge</para>
        /// <para>right: distance from the parent's right edge (overrides left)</para>
        /// </summary>
        public RectBound Anchor { get; set; }

        /// <summary>
        /// The coordinates at which the contents of this control should be positioned relative to the ImageViewPin itself. Works like standard CSS positioning. Only accepts px values. Defaults to {top: 0px, left: 0px}.
        /// <para>top: distance from the ImageViewPin's top edge</para>
        /// <para>bottom: distance from the ImageViewPin's bottom edge</para>
        /// <para>left: distance from the ImageViewPin's left edge</para>
        /// <para>right: distance from the ImageViewPin's right edge</para>
        /// </summary>
        public RectBound Position { get; set; }
    }
}
