using JavaScript;

namespace onyx
{
    /// <summary>
    /// A control that displays an icon. The icon image is specified by setting the src property to a url.
    /// In onyx icons have a size of 32x32 pixels. Since the icon image is applied as a css background, the height/width of an icon must be set if an image of a different size is used.
    /// When an icon should act like a button, use an onyx.IconButton.
    /// </summary>
    public class Icon : enyo.Control
    {
        public bool Disabled { get; set; }
    }
}
