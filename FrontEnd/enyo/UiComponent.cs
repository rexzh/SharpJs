using System;

namespace enyo
{
    public abstract class UiComponent : Component
    {
        public Component Container { get; set; }
        public Component Parent { get; set; }
        public string ControlParentName { get; set; }
        public Layout LayoutKind;

        public void AdjustComponentProps(object props) { }

        /// <summary>
        /// Destroys "client controls", the same set of controls returned by GetClientControls.
        /// </summary>
        public void DestroyClientControls() { }

        /// <summary>
        /// Returns all non-chrome controls.
        /// </summary>
        /// <returns></returns>
        public UiComponent[] GetClientControls() { return null; }

        /// <summary>
        /// Returns all controls.
        /// </summary>
        /// <returns></returns>
        public UiComponent[] GetControls() { return null; }

        public bool IsDescendantOf(UiComponent c) { return false; }

        public virtual void ParentChanged(Component oldParent)
        {
        }

        public virtual void ContainerChanged(Component oldContainer)
        {
        }

        //Extend:Don't expose now
        //discoverControlParent
        //importProps
        //handlers???
    }
}
