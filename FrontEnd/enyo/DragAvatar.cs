using System;

namespace enyo
{
    public class DragAvatar : Component
    {
        public void Hide() { }
        public void Show() { }

        public bool Showing { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }

        //Extend: not expose, need subclass arg?
        //public void Drag(EnyoEventArgs arg)
        //{ 
        //}
    }
}
