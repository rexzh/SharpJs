using System;

namespace onyx
{
    /// <summary>
    /// onyx.Tooltip is a kind of onyx.Popup that works with an onyx.TooltipDecorator. It automatically displays a tooltip when the user hovers over the decorator.
    /// The tooltip is positioned around the decorator where there is available window space.
    /// </summary>
    public class Tooltip : Popup
    {
        public int DefaultLeft;
        public int ShowDelay;
    }
}
