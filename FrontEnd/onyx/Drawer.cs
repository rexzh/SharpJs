using JavaScript;

using enyo;

namespace onyx
{
    /// <summary>
    /// A control that appears or disappears based on its open property. It appears or disappears with a sliding animation whose direction is determined by the orient property.
    /// </summary>
    public class Drawer : enyo.Control
    {
        public bool Open { get; set; }
        public Direction Orient { get; set; }
        public bool Animated { get; set; }
    }
}
