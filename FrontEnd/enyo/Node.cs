using System;

namespace enyo
{
    public class Node : Control
    {
        public bool Expandable { get; set; }
        public bool Expanded { get; set; }
        public string Icon { get; set; }
        public bool Collapsible { get; set; }
    }
}
