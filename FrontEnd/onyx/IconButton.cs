using JavaScript;

namespace onyx
{
    /// <summary>
    /// A icon that acts like a button. The icon image is specified by setting the src property to a url.
    /// If an icon should be combined with text inside a button, use an onyx.Icon inside an onyx.Button.
    /// The image associated with the src property of the onyx.IconButton is assumed to be 32x64 pixel strip with the top image showing normally, and the bottom one showing with the button is hovered over or active.
    /// </summary>
    public class IconButton : Icon
    {
        public bool Active { get; set; }
    }
}
