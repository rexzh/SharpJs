using JavaScript;

namespace onyx
{
    /// <summary>
    /// An onyx styled RichText control. In addition to the features of enyo.RichText, the defaultFocus property can be set to true to focus the richtext when it's rendered. Only one richtext should be set as the defaultFocus.
    /// Typically an RichText is surrounded with an onyx.InputDecorator which provides styling.
    /// RichTexts need to be explicitly sized for width. RichText is not supported on Android < 3.
    /// </summary>
    public class RichText : enyo.RichText
    {
    }
}
