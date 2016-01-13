using JavaScript;

namespace enyo
{
    /// <summary>
    /// enyo.ImageView is a control that displays an image at a given scaling factor, with enhanced support for double-tap/double-click to zoom, panning, mousewheel zooming and pinch-zoom (on touchscreen devices that support it).
    /// </summary>
    public class ImageView : Scroller
    {
        /// <summary>
        /// If true (the default), the zoom action triggered by a double-tap (or double-click) will be animated.
        /// </summary>
        public bool Animate;

        /// <summary>
        /// If true (the default), allows propagation of vertical drag events when already at the top or bottom of the pannable area.
        /// </summary>
        public bool VerticalDragPropagation;

        /// <summary>
        /// If true (the default), allows propagation of horizontal drag events when already at the left or right edge of the pannable area.*/
        /// </summary>
        public bool HorizontalDragPropagation;

        /// <summary>
        /// The scale at which the image should be displayed. 
        /// It may be any positive numeric value 
        /// or one of the following key words (which will be resolved to a value dynamically):
        /// <para>auto/width/height</para>
        /// </summary>
        public ImageScale Scale { get; set; }

        /// <summary>
        /// Disables the zoom functionality
        /// </summary>
        public bool DisableZoom { get; set; }

        /// <summary>
        /// Fires whenever the user adjusts the zoom of the image, via double-tap/double-click, mousewheel, or pinch-zoom.
        /// event.scale contains the new scaling factor for the image.
        /// </summary>
        public EnyoEventHandler<ImageView, ImageScaleEventArgs> onZoom;
    }

    [NoCompile]
    public sealed class ImageScaleEventArgs : EnyoEventArgs
    {
        public float Scale;
    }
}
